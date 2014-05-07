<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class romgotxt
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
        Me.components = New System.ComponentModel.Container()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenombrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.file_1 = New System.Windows.Forms.RichTextBox()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemplazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompilrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoDisponibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.abrir_archivo = New System.Windows.Forms.OpenFileDialog()
        Me.guardar_archivo = New System.Windows.Forms.SaveFileDialog()
        Me.barra_status = New System.Windows.Forms.StatusStrip()
        Me.num_lin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.tabs.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.barra_status.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.AllowDrop = True
        Me.tabs.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.Location = New System.Drawing.Point(0, 24)
        Me.tabs.Multiline = True
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(692, 337)
        Me.tabs.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenombrarToolStripMenuItem, Me.CerrarToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 48)
        '
        'RenombrarToolStripMenuItem
        '
        Me.RenombrarToolStripMenuItem.Name = "RenombrarToolStripMenuItem"
        Me.RenombrarToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RenombrarToolStripMenuItem.Text = "Renombrar"
        '
        'CerrarToolStripMenuItem1
        '
        Me.CerrarToolStripMenuItem1.Name = "CerrarToolStripMenuItem1"
        Me.CerrarToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.CerrarToolStripMenuItem1.Text = "Cerrar"
        '
        'TabPage1
        '
        Me.TabPage1.AllowDrop = True
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.file_1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(684, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nueva"
        '
        'file_1
        '
        Me.file_1.BackColor = System.Drawing.Color.LightGray
        Me.file_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.file_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.file_1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file_1.ForeColor = System.Drawing.Color.Black
        Me.file_1.Location = New System.Drawing.Point(3, 3)
        Me.file_1.Name = "file_1"
        Me.file_1.Size = New System.Drawing.Size(678, 305)
        Me.file_1.TabIndex = 0
        Me.file_1.Text = ""
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Menu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdicionToolStripMenuItem, Me.CompilrToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(692, 24)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPestañaToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.ShellToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevaPestañaToolStripMenuItem
        '
        Me.NuevaPestañaToolStripMenuItem.Name = "NuevaPestañaToolStripMenuItem"
        Me.NuevaPestañaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevaPestañaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar Como..."
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ShellToolStripMenuItem
        '
        Me.ShellToolStripMenuItem.Name = "ShellToolStripMenuItem"
        Me.ShellToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ShellToolStripMenuItem.Text = "Shell"
        '
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.DeshacerToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.RemplazarToolStripMenuItem})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.EdicionToolStripMenuItem.Text = "Edicion"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'RemplazarToolStripMenuItem
        '
        Me.RemplazarToolStripMenuItem.Name = "RemplazarToolStripMenuItem"
        Me.RemplazarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RemplazarToolStripMenuItem.Text = "Remplazar"
        '
        'CompilrToolStripMenuItem
        '
        Me.CompilrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoDisponibleToolStripMenuItem})
        Me.CompilrToolStripMenuItem.Name = "CompilrToolStripMenuItem"
        Me.CompilrToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CompilrToolStripMenuItem.Text = "Compilar"
        '
        'NoDisponibleToolStripMenuItem
        '
        Me.NoDisponibleToolStripMenuItem.Name = "NoDisponibleToolStripMenuItem"
        Me.NoDisponibleToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NoDisponibleToolStripMenuItem.Text = "No disponible... :("
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De..."
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda..."
        '
        'abrir_archivo
        '
        Me.abrir_archivo.FileName = "nombre_archivo"
        '
        'barra_status
        '
        Me.barra_status.BackColor = System.Drawing.Color.DimGray
        Me.barra_status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.num_lin, Me.ToolStripStatusLabel2})
        Me.barra_status.Location = New System.Drawing.Point(0, 339)
        Me.barra_status.Name = "barra_status"
        Me.barra_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.barra_status.Size = New System.Drawing.Size(692, 22)
        Me.barra_status.TabIndex = 2
        Me.barra_status.Text = "StatusStrip1"
        '
        'num_lin
        '
        Me.num_lin.MergeIndex = 1
        Me.num_lin.Name = "num_lin"
        Me.num_lin.Size = New System.Drawing.Size(13, 17)
        Me.num_lin.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel2.Text = "Lineas"
        '
        'romgotxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(692, 361)
        Me.Controls.Add(Me.barra_status)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.Menu
        Me.Name = "romgotxt"
        Me.Text = "txtRom"
        Me.tabs.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.barra_status.ResumeLayout(False)
        Me.barra_status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemplazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompilrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoDisponibleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_1 As System.Windows.Forms.RichTextBox
    Friend WithEvents NuevaPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RenombrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents abrir_archivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents guardar_archivo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barra_status As System.Windows.Forms.StatusStrip
    Friend WithEvents num_lin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
