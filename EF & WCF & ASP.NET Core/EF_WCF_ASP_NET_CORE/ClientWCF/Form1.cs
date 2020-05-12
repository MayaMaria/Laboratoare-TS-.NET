using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PostComment;

namespace ClientWCF
{
    public partial class Form1 : Form
    {
        List<Post> posts = new List<Post>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            posts = LoadPosts().ToList<Post>();
            postBindingSource.DataSource = posts;
            dataGridViewComment.Columns[0].Width = 0;
            if (dataGridViewComment.Rows.Count > 0)
                commentBindingSource.DataSource = posts[0].Comments;
        }

        private static PostComment.Post[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            PostComment.Post[] p = pc.GetPosts();
            return p;
        }

        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            commentBindingSource.DataSource = null;
            commentBindingSource.DataSource = posts[e.RowIndex].Comments;
        }
    }
}
