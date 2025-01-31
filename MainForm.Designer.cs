namespace SQLViewer
{
    partial class MainForm
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
        private void InitializeComponent()
        {
            btnEmployees = new Button();
            btnOrders = new Button();
            btnFreightSummary = new Button();
            dataGridView = new DataGridView();
            labelOrdersByLastName = new Label();
            textBoxOrdersByLastName = new TextBox();
            btnShowOrdersByLastName = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(12, 12);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(126, 23);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Show Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(144, 12);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(126, 23);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Show Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnFreightSummary
            // 
            btnFreightSummary.Location = new Point(634, 12);
            btnFreightSummary.Name = "btnFreightSummary";
            btnFreightSummary.Size = new Size(154, 23);
            btnFreightSummary.TabIndex = 2;
            btnFreightSummary.Text = "Show Freight Summary";
            btnFreightSummary.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 41);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(1293, 478);
            dataGridView.TabIndex = 3;
            // 
            // labelOrdersByLastName
            // 
            labelOrdersByLastName.AutoSize = true;
            labelOrdersByLastName.Location = new Point(276, 16);
            labelOrdersByLastName.Name = "labelOrdersByLastName";
            labelOrdersByLastName.Size = new Size(120, 15);
            labelOrdersByLastName.TabIndex = 4;
            labelOrdersByLastName.Text = "Orders by Last Name:";
            // 
            // textBoxOrdersByLastName
            // 
            textBoxOrdersByLastName.Location = new Point(402, 12);
            textBoxOrdersByLastName.Name = "textBoxOrdersByLastName";
            textBoxOrdersByLastName.Size = new Size(100, 23);
            textBoxOrdersByLastName.TabIndex = 5;
            // 
            // btnShowOrdersByLastName
            // 
            btnShowOrdersByLastName.Location = new Point(508, 12);
            btnShowOrdersByLastName.Name = "btnShowOrdersByLastName";
            btnShowOrdersByLastName.Size = new Size(75, 23);
            btnShowOrdersByLastName.TabIndex = 6;
            btnShowOrdersByLastName.Text = "Show";
            btnShowOrdersByLastName.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 531);
            Controls.Add(btnShowOrdersByLastName);
            Controls.Add(textBoxOrdersByLastName);
            Controls.Add(labelOrdersByLastName);
            Controls.Add(dataGridView);
            Controls.Add(btnFreightSummary);
            Controls.Add(btnOrders);
            Controls.Add(btnEmployees);
            Name = "MainForm";
            Text = "SQL Viewer";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmployees;
        private Button btnOrders;
        private Button btnFreightSummary;
        private DataGridView dataGridView;
        private Label labelOrdersByLastName;
        private TextBox textBoxOrdersByLastName;
        private Button btnShowOrdersByLastName;
    }
}
