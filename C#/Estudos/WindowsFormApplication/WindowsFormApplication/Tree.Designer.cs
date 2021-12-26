
namespace WindowsFormApplication
{
    partial class Tree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Node7";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Node1";
            treeNode12.Name = "Node8";
            treeNode12.Text = "Node8";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Node0";
            treeNode14.Name = "Node6";
            treeNode14.Text = "Node6";
            treeNode15.Name = "Node5";
            treeNode15.Text = "Node5";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Node3";
            treeNode17.Name = "Node4";
            treeNode17.Text = "Node4";
            treeNode18.Name = "Node2";
            treeNode18.Text = "Node2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(776, 365);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // buttonTree
            // 
            this.buttonTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTree.Location = new System.Drawing.Point(30, 383);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(100, 23);
            this.buttonTree.TabIndex = 1;
            this.buttonTree.Text = "Checados";
            this.buttonTree.UseVisualStyleBackColor = true;
            this.buttonTree.Click += new System.EventHandler(this.buttonTree_Click);
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTree);
            this.Controls.Add(this.treeView1);
            this.Name = "Tree";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.Tree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonTree;
    }
}