Public Class FormAbout
    Private Sub LinkLabelGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGithub.LinkClicked
        Process.Start("https://github.com/JulWas797")
    End Sub

    Private Sub LinkLabelCoffee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCoffee.LinkClicked
        Process.Start("https://bmc.link/julwas797")
    End Sub

    Private Sub LinkLabelWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelWebsite.LinkClicked
        Process.Start("https://julwas797.github.io/")
    End Sub
End Class