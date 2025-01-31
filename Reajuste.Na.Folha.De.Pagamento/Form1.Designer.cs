namespace Reajuste.Na.Folha.De.Pagamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtArquivo = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ofdListaFuncionarios = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTotalSemReajuste = new Label();
            lblTotalComReajuste = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblPorcentagem = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtArquivo
            // 
            resources.ApplyResources(txtArquivo , "txtArquivo");
            txtArquivo.Name = "txtArquivo";
            txtArquivo.ReadOnly = true;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1 , "dataGridView1");
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI" , 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI" , 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI" , 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // button1
            // 
            resources.ApplyResources(button1 , "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ofdListaFuncionarios
            // 
            ofdListaFuncionarios.DefaultExt = "*.txt";
            ofdListaFuncionarios.FileName = "openFileDialog1";
            resources.ApplyResources(ofdListaFuncionarios , "ofdListaFuncionarios");
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1 , "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(lblTotalSemReajuste , 2 , 1);
            tableLayoutPanel1.Controls.Add(lblTotalComReajuste , 1 , 1);
            tableLayoutPanel1.Controls.Add(label2 , 1 , 0);
            tableLayoutPanel1.Controls.Add(label3 , 2 , 0);
            tableLayoutPanel1.Controls.Add(label1 , 0 , 0);
            tableLayoutPanel1.Controls.Add(lblPorcentagem , 0 , 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblTotalSemReajuste
            // 
            resources.ApplyResources(lblTotalSemReajuste , "lblTotalSemReajuste");
            lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            // 
            // lblTotalComReajuste
            // 
            resources.ApplyResources(lblTotalComReajuste , "lblTotalComReajuste");
            lblTotalComReajuste.Name = "lblTotalComReajuste";
            // 
            // label2
            // 
            resources.ApplyResources(label2 , "label2");
            label2.BackColor = Color.Yellow;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3 , "label3");
            label3.BackColor = Color.Yellow;
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1 , "label1");
            label1.BackColor = Color.Yellow;
            label1.Name = "label1";
            // 
            // lblPorcentagem
            // 
            resources.ApplyResources(lblPorcentagem , "lblPorcentagem");
            lblPorcentagem.Name = "lblPorcentagem";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1 , "panel1");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Name = "panel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this , "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtArquivo);
            Controls.Add(panel1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtArquivo;
        private DataGridView dataGridView1;
        private Button button1;
        private OpenFileDialog ofdListaFuncionarios;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTotalSemReajuste;
        private Label lblPorcentagem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalComReajuste;
        private Panel panel1;
    }
}
