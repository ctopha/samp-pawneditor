Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            For Each s As String In e.CommandLine
                'Thanks to:
                'Cybernavigator @ portugal-a-programar.org - http://www.portugal-a-programar.org/forum/index.php?topic=20665.0
                'JohnH @ vbdotnetforums.com - http://www.vbdotnetforums.com/vb-net-general-discussion/43009-opening-files-within-single-instance-app-using-file-association.html#post122665

                Dim filePathAndName As String = s.ToString
                Dim fileName As String = System.IO.Path.GetFileName(filePathAndName)

                frmMain.NewScintillaInstance(4, fileName, filePathAndName) 'Open the file
            Next
        End Sub
    End Class

End Namespace

