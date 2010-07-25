Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Microsoft.Win32
Imports System.Security.AccessControl
Imports System.IO

'CREATED BY AIDAN MICHAEL FOLLESTAD
'COPYWRITE 2010, AF PRODUCTIONS.

Namespace Associations
    Class RegistryUtilities
        Public Function RenameSubKey(ByVal parentKey As RegistryKey, ByVal subKeyName As String, ByVal newSubKeyName As String) As Boolean
            CopyKey(parentKey, subKeyName, newSubKeyName)
            parentKey.DeleteSubKeyTree(subKeyName)
            Return True
        End Function

        Public Function CopyKey(ByVal parentKey As RegistryKey, ByVal keyNameToCopy As String, ByVal newKeyName As String) As Boolean
            'Create new key
            Dim destinationKey As RegistryKey = parentKey.CreateSubKey(newKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree)

            'Open the sourceKey we are copying from
            Dim sourceKey As RegistryKey = parentKey.OpenSubKey(keyNameToCopy, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl)

            RecurseCopyKey(sourceKey, destinationKey)

            Return True
        End Function

        Private Sub RecurseCopyKey(ByVal sourceKey As RegistryKey, ByVal destinationKey As RegistryKey)
            'copy all the values
            For Each valueName As String In sourceKey.GetValueNames()
                Dim objValue As Object = sourceKey.GetValue(valueName)
                Dim valKind As RegistryValueKind = sourceKey.GetValueKind(valueName)
                destinationKey.SetValue(valueName, objValue, valKind)
            Next

            'For Each subKey 
            'Create a new subKey in destinationKey 
            'Call myself 
            For Each sourceSubKeyName As String In sourceKey.GetSubKeyNames()
                Dim sourceSubKey As RegistryKey = sourceKey.OpenSubKey(sourceSubKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl)
                Dim destSubKey As RegistryKey = destinationKey.CreateSubKey(sourceSubKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree)
                RecurseCopyKey(sourceSubKey, destSubKey)
            Next
        End Sub
    End Class

    ''' <summary>
    ''' Reference to an .ico file used by AF_FileAssociator.
    ''' </summary>
    Public Class ProgramIcon
        Public Sub New(ByVal iconPath__1 As String)
            IconPath = iconPath__1.Trim()
        End Sub

        Public ReadOnly IconPath As String

        Public ReadOnly Property IsValid() As Boolean
            Get
                Dim getInfo As New FileInfo(IconPath)

                If getInfo.Exists AndAlso getInfo.Extension = ".ico" Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
    End Class

    ''' <summary>
    ''' Reference to an list of executable files used by AF_FileAssociator.
    ''' </summary>
    Public Class OpenWithList
        Public Sub New(ByVal openWithPaths As String())
            Dim toReturn As New List(Of String)()
            Dim getInfo As FileInfo

            For Each file As String In openWithPaths
                getInfo = New FileInfo(file)
                toReturn.Add(getInfo.Name)
            Next

            List = toReturn.ToArray()
        End Sub

        Public ReadOnly List As String()
    End Class

    ''' <summary>
    ''' Reference to a executable file used by AF_FileAssociator.
    ''' </summary>
    Public Class ExecApplication
        Public Sub New(ByVal appPath As String)
            Path = appPath.Trim()
        End Sub

        Public ReadOnly Path As String

        ''' <summary>
        ''' Gets a value indicating whether this Executable Application is an .exe, and that it exists.
        ''' </summary>
        Public ReadOnly Property IsValid() As Boolean
            Get
                Dim getInfo As New FileInfo(Path)
                If getInfo.Exists Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
    End Class

    ''' <summary>
    ''' AF_Lib's class for associating files with programs and icons.
    ''' </summary>
    Public Class AF_FileAssociator
        ''' <summary>
        ''' Initializes a new AF_FileAssociator class object for the specified file extension.
        ''' </summary>
        Public Sub New(ByVal extension__1 As String)
            Extension = extension__1
        End Sub

        ''' <summary>
        ''' Gets the extension set for this file associator to control when you initialized it.
        ''' </summary>
        Public ReadOnly Extension As String

        Private ReadOnly Property GetProgID() As String
            Get
                Dim toReturn As String = String.Empty

                If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("") IsNot Nothing Then
                        toReturn = Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("").ToString()
                    End If
                End If

                Return toReturn
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether the association keys exist. If the extension key doesn't, the program cannot get the name of the program association key making it appear to not exist.
        ''' </summary>
        Public ReadOnly Property Exists() As Boolean
            Get
                Dim extKeyExists As Boolean = False
                Dim progIDkeyExists As Boolean = False

                If Registry.ClassesRoot.OpenSubKey(Extension) IsNot Nothing Then
                    extKeyExists = True

                    If GetProgID IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID) IsNot Nothing Then
                            progIDkeyExists = True
                        End If
                    End If
                End If

                If extKeyExists AndAlso progIDkeyExists Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Create or overwrite a current file association for this FileAssociator's set extension.
        ''' </summary>
        ''' <param name="progID">The basic application name that uses this file extension.</param>
        ''' <param name="description">The desription of this file extension and/or program that uses it.</param>
        ''' <param name="defaultIcon">The icon to show on the program and it's files.</param>
        ''' <param name="execApp">The application that will be run when the file extension is clicked.</param>
        ''' <param name="openWith">The programs that appear in the OpenWith list.</param>
        ''' <exception cref="Exception">Thrown when an error occurs that will prevent it from working correctly.</exception>
        Public Sub Create(ByVal progID As String, ByVal description As String, ByVal defaultIcon As ProgramIcon, ByVal execApp As ExecApplication, ByVal openWith As OpenWithList)
            If progID IsNot Nothing Then
                If defaultIcon.IsValid AndAlso execApp.IsValid Then
                    Registry.ClassesRoot.CreateSubKey(Extension).SetValue("", progID)
                    Dim key As RegistryKey = Registry.ClassesRoot.CreateSubKey(progID, RegistryKeyPermissionCheck.ReadWriteSubTree)

                    If description IsNot Nothing Then
                        key.SetValue("", description, RegistryValueKind.[String])
                    End If

                    If defaultIcon IsNot Nothing AndAlso defaultIcon.IsValid Then
                        key.CreateSubKey("DefaultIcon").SetValue("", defaultIcon.IconPath, RegistryValueKind.[String])
                    Else
                        Throw New Exception("The default icon you entered is either null or doesn't exist...")
                    End If

                    If execApp IsNot Nothing AndAlso execApp.IsValid Then
                        key.CreateSubKey("Shell\Open\Command").SetValue("", execApp.Path & " %1", RegistryValueKind.[String])
                    Else
                        Throw New Exception("The executable application you entered is either null or not an .exe format...")
                    End If

                    If openWith IsNot Nothing Then
                        key = key.CreateSubKey("OpenWithList", RegistryKeyPermissionCheck.ReadWriteSubTree)
                        For Each file As String In openWith.List
                            key.CreateSubKey(file)
                        Next
                    End If

                    key.Flush()
                    key.Close()
                Else
                    Throw New Exception("Either the icon or executable application object is invalid...")
                End If
            Else
                Throw New Exception("The program ID you entered is null...")
            End If
        End Sub

        ''' <summary>
        ''' Gets or sets the program ID for this extension.
        ''' </summary>
        Public Property ID() As String
            Get
                Dim toReturn As String = String.Empty

                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        toReturn = GetProgID
                    Else
                        Throw New Exception("The extension's association key (" & GetProgID & ") doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If

                Return toReturn
            End Get
            Set(ByVal value As String)
                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        Dim beforeID As String = GetProgID
                        Dim reg As New RegistryUtilities()
                        reg.RenameSubKey(Registry.ClassesRoot, beforeID, value)

                        Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).SetValue("", value, RegistryValueKind.[String])
                    Else
                        Throw New Exception("The extension's association key (" & GetProgID & ") doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the description for this file extension and/or it's program association.
        ''' </summary>
        Public Property Description() As String
            Get
                Dim toReturn As String = String.Empty

                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            If Registry.ClassesRoot.OpenSubKey(GetProgID, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("") IsNot Nothing Then
                                toReturn = Registry.ClassesRoot.OpenSubKey(GetProgID, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("").ToString()
                            End If
                        Else
                            Throw New Exception("The extension's progam association key (" & GetProgID & ") doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If

                Return toReturn
            End Get
            Set(ByVal value As String)
                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            Registry.ClassesRoot.OpenSubKey(GetProgID, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).SetValue("", value, RegistryValueKind.[String])
                        Else
                            Throw New Exception("The extension's progam association key (" & GetProgID & ") doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the icon shown on this file extension and/or it's program association.
        ''' </summary>
        Public Property DefaultIcon() As ProgramIcon
            Get
                Dim toReturn As ProgramIcon = Nothing

                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            If Registry.ClassesRoot.OpenSubKey(GetProgID & "\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                                If Registry.ClassesRoot.OpenSubKey(GetProgID & "\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("") IsNot Nothing Then
                                    toReturn = New ProgramIcon(Registry.ClassesRoot.OpenSubKey(GetProgID & "\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("").ToString())
                                End If
                            End If
                        Else
                            Throw New Exception("The extension's progam default icon association key doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If

                Return toReturn
            End Get
            Set(ByVal value As ProgramIcon)
                If Me.Exists Then
                    If value.IsValid Then
                        If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            If Registry.ClassesRoot.OpenSubKey(GetProgID & "\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                                Registry.ClassesRoot.OpenSubKey(GetProgID & "\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).SetValue("", value.IconPath, RegistryValueKind.[String])
                            Else
                                Throw New Exception("The extension's progam default icon association key doesn't exist, please use the Create() function to setup everything...")
                            End If
                        Else
                            Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The value your trying to set to this DefaultIcon variable is not valid... the icon doesn't exist or it's not an .ico file.")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the executable ran when this file extension is opened.
        ''' </summary>
        Public Property Executable() As ExecApplication
            Get
                Dim execApp As ExecApplication = Nothing

                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID & "\Shell\Open\Command", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            If Registry.ClassesRoot.OpenSubKey(GetProgID & "\Shell\Open\Command", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("") IsNot Nothing Then
                                Dim path As String = Registry.ClassesRoot.OpenSubKey(GetProgID & "\Shell\Open\Command", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetValue("").ToString()

                                execApp = New ExecApplication(path.Substring(0, path.LastIndexOf("%"c) - 1))
                            End If
                        Else
                            Throw New Exception("The extension's progam executable association key doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If

                Return execApp
            End Get
            Set(ByVal value As ExecApplication)
                If Me.Exists Then
                    If value.IsValid Then
                        If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            If Registry.ClassesRoot.OpenSubKey(GetProgID & "\Shell\Open\Command", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                                Registry.ClassesRoot.OpenSubKey(GetProgID & "\Shell\Open\Command", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).SetValue("", value.Path & " %1", RegistryValueKind.[String])
                            Else
                                Throw New Exception("The extension's progam executable association key doesn't exist, please use the Create() function to setup everything...")
                            End If
                        Else
                            Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The value uses to set this variable isn't valid... the file doesn't exist or it's not an .exe file.")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the list of programs shown in the OpenWith list.
        ''' </summary>
        Public Property OpenWith() As OpenWithList
            Get
                Dim toReturn As OpenWithList = Nothing

                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID & "\OpenWithList", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            Dim list As New List(Of String)()
                            For Each file As String In Registry.ClassesRoot.OpenSubKey(GetProgID & "\OpenWithList", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).GetSubKeyNames()
                                list.Add(file)
                            Next

                            toReturn = New OpenWithList(list.ToArray())
                            list.Clear()
                        Else
                            Throw New Exception("The extension's progam open with executable association key doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If

                Return toReturn
            End Get
            Set(ByVal value As OpenWithList)
                If Me.Exists Then
                    If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                        If Registry.ClassesRoot.OpenSubKey(GetProgID & "\OpenWithList", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                            Registry.ClassesRoot.DeleteSubKeyTree(GetProgID & "\OpenWithList")
                            Dim key As RegistryKey = Registry.ClassesRoot.CreateSubKey(GetProgID & "\OpenWithList", RegistryKeyPermissionCheck.ReadWriteSubTree)

                            For Each file As String In value.List
                                key.CreateSubKey(file)
                            Next

                            key.Close()
                        Else
                            Throw New Exception("The extension's progam open with executable association key doesn't exist, please use the Create() function to setup everything...")
                        End If
                    Else
                        Throw New Exception("The extension association key doesn't exist, please use the Create() function to setup everything...")
                    End If
                Else
                    Throw New Exception("One of your association keys don't exist, use the create method to get started...")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Deletes all registry resources used for this file associations.
        ''' </summary>
        Public Sub Delete()
            If Me.Exists Then
                If Registry.ClassesRoot.OpenSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) IsNot Nothing Then
                    Try
                        Registry.ClassesRoot.DeleteSubKeyTree(GetProgID)
                        Registry.ClassesRoot.DeleteSubKeyTree(Extension)
                    Catch ex As Exception
                        Throw New Exception("Failed to delete all keys used in the '" & Extension & "' file association, error: " & ex.Message)
                    End Try
                End If
            Else
                Throw New Exception("One of your association keys don't exist, use the create method to get started...")
            End If
        End Sub
    End Class
End Namespace

