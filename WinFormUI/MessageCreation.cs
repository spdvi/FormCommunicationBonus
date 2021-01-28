using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MessageCreation : Form
    {
        public MessageCreation()
        {
            InitializeComponent();
        }

        public event EventHandler<MessageModelEventArgs> MessageCreated;

        private void CreateMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(messageText.Text))
            {
                MessageModel message = new MessageModel
                {
                    Name = nameText.Text,
                    Message = messageText.Text
                };

                MessageModelEventArgs messageModelEventArgs = new MessageModelEventArgs();
                messageModelEventArgs.message = message;
                MessageCreated?.Invoke(this, messageModelEventArgs);
                this.Close();
            }
        }
    }
}
