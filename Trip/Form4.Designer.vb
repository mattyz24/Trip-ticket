<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.date_of_request = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.date_of_travel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.place_of_travel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.office = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.purpose = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.driver = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.plate_number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dispatcher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(294, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "LIST OF CANCELLED TRIPS"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.date_of_request, Me.date_of_travel, Me.place_of_travel, Me.office, Me.purpose, Me.driver, Me.plate_number, Me.time, Me.dispatcher})
        Me.ListView1.Location = New System.Drawing.Point(12, 97)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(965, 403)
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'date_of_request
        '
        Me.date_of_request.Text = "date_of_request"
        Me.date_of_request.Width = 100
        '
        'date_of_travel
        '
        Me.date_of_travel.Text = "date_of_travel"
        Me.date_of_travel.Width = 100
        '
        'place_of_travel
        '
        Me.place_of_travel.Text = "place_of_travel"
        Me.place_of_travel.Width = 130
        '
        'office
        '
        Me.office.Text = "office"
        Me.office.Width = 100
        '
        'purpose
        '
        Me.purpose.Text = "purpose"
        Me.purpose.Width = 130
        '
        'driver
        '
        Me.driver.Text = "driver"
        Me.driver.Width = 100
        '
        'plate_number
        '
        Me.plate_number.Text = "plate_number"
        Me.plate_number.Width = 100
        '
        'time
        '
        Me.time.Text = "time"
        Me.time.Width = 100
        '
        'dispatcher
        '
        Me.dispatcher.Text = "dispatcher"
        Me.dispatcher.Width = 100
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents date_of_request As System.Windows.Forms.ColumnHeader
    Friend WithEvents date_of_travel As System.Windows.Forms.ColumnHeader
    Friend WithEvents place_of_travel As System.Windows.Forms.ColumnHeader
    Friend WithEvents office As System.Windows.Forms.ColumnHeader
    Friend WithEvents purpose As System.Windows.Forms.ColumnHeader
    Friend WithEvents driver As System.Windows.Forms.ColumnHeader
    Friend WithEvents plate_number As System.Windows.Forms.ColumnHeader
    Friend WithEvents time As System.Windows.Forms.ColumnHeader
    Friend WithEvents dispatcher As System.Windows.Forms.ColumnHeader
End Class
