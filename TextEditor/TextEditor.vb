Imports System.Drawing.Text
Imports System.IO
Public Class TextEditor
    Private Sub Document_TextChanged(sender As Object, e As EventArgs) Handles Document.TextChanged

    End Sub

    Private Sub TextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbNew_Click(sender As Object, e As EventArgs) Handles tbNew.Click
        Document.Clear()
    End Sub

    Private Sub mMNew_Click(sender As Object, e As EventArgs) Handles mMNew.Click
        Document.Clear()
    End Sub

    Private Sub mMOpen_Click(sender As Object, e As EventArgs) Handles mMOpen.Click
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Document.LoadFile(openWork.FileName,
            RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub tbOpen_Click(sender As Object, e As EventArgs) Handles tbOpen.Click
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Document.LoadFile(openWork.FileName,
            RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub tbSave_Click(sender As Object, e As EventArgs) Handles tbSave.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Document.SaveFile(saveWork.FileName,
                RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mMSave_Click(sender As Object, e As EventArgs) Handles mMSave.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Document.SaveFile(saveWork.FileName,
                RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mMExit_Click(sender As Object, e As EventArgs) Handles mMExit.Click
        Me.Close()
    End Sub

    Private Sub mMUndo_Click(sender As Object, e As EventArgs) Handles mMUndo.Click
        Document.Undo()
    End Sub

    Private Sub mMRedo_Click(sender As Object, e As EventArgs) Handles mMRedo.Click
        Document.Redo()
    End Sub

    Private Sub mMCut_Click(sender As Object, e As EventArgs) Handles mMCut.Click
        Document.Cut()
    End Sub

    Private Sub tbCut_Click(sender As Object, e As EventArgs) Handles tbCut.Click
        Document.Cut()
    End Sub

    Private Sub tbCopy_Click(sender As Object, e As EventArgs) Handles tbCopy.Click
        Document.Copy()
    End Sub

    Private Sub mMCopy_Click(sender As Object, e As EventArgs) Handles mMCopy.Click
        Document.Copy()
    End Sub

    Private Sub mMPaste_Click(sender As Object, e As EventArgs) Handles mMPaste.Click
        Document.Paste()
    End Sub

    Private Sub tbPaste_Click(sender As Object, e As EventArgs) Handles tbPaste.Click
        Document.Paste()
    End Sub

    Private Sub mMSelectAll_Click(sender As Object, e As EventArgs) Handles mMSelectAll.Click
        Document.SelectAll()
    End Sub

    Private Sub mMCustomize_Click(sender As Object, e As EventArgs) Handles mMCustomize.Click
        Dim ColorPicker As New ColorDialog()
        ColorPicker.AllowFullOpen = True
        ColorPicker.FullOpen = True
        ColorPicker.AnyColor = True
        If ColorPicker.ShowDialog = Windows.Forms.DialogResult.OK Then
            mainMenu.BackColor = ColorPicker.Color
            Tools.BackColor = ColorPicker.Color
            Status.BackColor = ColorPicker.Color
        End If
    End Sub

    Private Sub tbBold_Click(sender As Object, e As EventArgs) Handles tbBold.Click
        Dim bfont As New Font(Document.Font, FontStyle.Bold)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Italic Then
            Document.SelectionFont = rfont

        End If
    End Sub

    Private Sub tbItalic_Click(sender As Object, e As EventArgs) Handles tbItalic.Click
        Dim Ifont As New Font(Document.Font, FontStyle.Italic)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Italic Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = Ifont
        End If
    End Sub

    Private Sub tbUnderline_Click(sender As Object, e As EventArgs) Handles tbUnderline.Click
        Dim Ufont As New Font(Document.Font, FontStyle.Underline)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Underline Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = Ufont
        End If
    End Sub

    Private Sub tbStrike_Click(sender As Object, e As EventArgs) Handles tbStrike.Click
        Dim Sfont As New Font(Document.Font, FontStyle.Strikeout)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Strikeout Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = Sfont
        End If
    End Sub

    Private Sub tbAlignLeft_Click(sender As Object, e As EventArgs) Handles tbAlignLeft.Click
        Document.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub tbAlignCentre_Click(sender As Object, e As EventArgs) Handles tbAlignCentre.Click
        Document.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub tbAlignRight_Click(sender As Object, e As EventArgs) Handles tbAlignRight.Click
        Document.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub tbUpper_Click(sender As Object, e As EventArgs) Handles tbUpper.Click
        Document.SelectedText = Document.SelectedText.ToUpper()
    End Sub

    Private Sub tbLower_Click(sender As Object, e As EventArgs) Handles tbLower.Click
        Document.SelectedText = Document.SelectedText.ToLower()
    End Sub

    Private Sub tbZoom_Click(sender As Object, e As EventArgs) Handles tbZoom.Click
        If Document.ZoomFactor = 63 Then
            Exit Sub
        Else
            Document.ZoomFactor = Document.ZoomFactor + 1
        End If
    End Sub

    Private Sub tbZoomOut_Click(sender As Object, e As EventArgs) Handles tbZoomOut.Click
        If Document.ZoomFactor = 1 Then
            Exit Sub
        Else
            Document.ZoomFactor = Document.ZoomFactor - 1
        End If
    End Sub
End Class
