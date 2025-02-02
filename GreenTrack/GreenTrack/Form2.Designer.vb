<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelSideBar = New Panel()
        ShowButton = New Button()
        InventoryButton = New Button()
        SalesButton = New Button()
        CustomerButton = New Button()
        ReservationButton = New Button()
        ReportsButton = New Button()
        PanelSideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSideBar
        ' 
        PanelSideBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PanelSideBar.BackColor = Color.Olive
        PanelSideBar.Controls.Add(ReportsButton)
        PanelSideBar.Controls.Add(ReservationButton)
        PanelSideBar.Controls.Add(CustomerButton)
        PanelSideBar.Controls.Add(SalesButton)
        PanelSideBar.Controls.Add(InventoryButton)
        PanelSideBar.Controls.Add(ShowButton)
        PanelSideBar.Location = New Point(12, 12)
        PanelSideBar.Name = "PanelSideBar"
        PanelSideBar.Size = New Size(51, 665)
        PanelSideBar.TabIndex = 0
        ' 
        ' ShowButton
        ' 
        ShowButton.Location = New Point(3, 3)
        ShowButton.Name = "ShowButton"
        ShowButton.Size = New Size(46, 46)
        ShowButton.TabIndex = 1
        ShowButton.Text = "➤"
        ShowButton.UseVisualStyleBackColor = True
        ' 
        ' InventoryButton
        ' 
        InventoryButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        InventoryButton.Location = New Point(58, 69)
        InventoryButton.Name = "InventoryButton"
        InventoryButton.Size = New Size(230, 54)
        InventoryButton.TabIndex = 2
        InventoryButton.Text = "Inventory Module"
        InventoryButton.UseVisualStyleBackColor = True
        ' 
        ' SalesButton
        ' 
        SalesButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        SalesButton.Location = New Point(58, 137)
        SalesButton.Name = "SalesButton"
        SalesButton.Size = New Size(230, 54)
        SalesButton.TabIndex = 3
        SalesButton.Text = "Sales Module"
        SalesButton.UseVisualStyleBackColor = True
        ' 
        ' CustomerButton
        ' 
        CustomerButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CustomerButton.Location = New Point(58, 205)
        CustomerButton.Name = "CustomerButton"
        CustomerButton.Size = New Size(230, 54)
        CustomerButton.TabIndex = 4
        CustomerButton.Text = "Customer Module"
        CustomerButton.UseVisualStyleBackColor = True
        ' 
        ' ReservationButton
        ' 
        ReservationButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ReservationButton.Location = New Point(58, 273)
        ReservationButton.Name = "ReservationButton"
        ReservationButton.Size = New Size(230, 54)
        ReservationButton.TabIndex = 5
        ReservationButton.Text = "Reservation Module"
        ReservationButton.UseVisualStyleBackColor = True
        ' 
        ' ReportsButton
        ' 
        ReportsButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ReportsButton.Location = New Point(58, 341)
        ReportsButton.Name = "ReportsButton"
        ReportsButton.Size = New Size(230, 54)
        ReportsButton.TabIndex = 6
        ReportsButton.Text = "Reports Module"
        ReportsButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(1326, 689)
        Controls.Add(PanelSideBar)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        PanelSideBar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents ShowButton As Button
    Friend WithEvents ReportsButton As Button
    Friend WithEvents ReservationButton As Button
    Friend WithEvents CustomerButton As Button
    Friend WithEvents SalesButton As Button
    Friend WithEvents InventoryButton As Button
End Class
