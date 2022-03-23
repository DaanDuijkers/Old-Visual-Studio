using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridviewSecondForm
{

    public partial class Form2 : Form
    {
        private Member member;

        public Member Member ()
        { 
            return member; 
        } 
        
        public void SetMembre (Member member)
        {
            this.member = member;
        }

        public Form2()
        {
            InitializeComponent();

            member = new Member();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            member.SetID((int)nudID.Value);
            member.SetName(txbName.Text);
            member.SetGender(rbMale.Checked == true ? 'M' : 'F');
            member.SetSkills(txbSkills.Text);
        }
    }
}
