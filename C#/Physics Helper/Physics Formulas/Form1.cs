using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Physics_Formulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formulaOut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void formulaInput_TextChanged(object sender, EventArgs e)
        {
            if (formulaInput.Text == "force" || formulaInput.Text == "newton's second law")
            {
                formulaOut.Text = @"F=ma 
a force is any interaction that, when unopposed, will change the motion of an object.";
            }
            else if (formulaInput.Text == "velocity")
            {
                formulaOut.Text = @"v=r/t
The speed of something in a given direction.";
            }
            else if (formulaInput.Text == "acceleration")
            {
                formulaOut.Text = @"a=v-u/t
a=F/m
Acceleration is a vector quantity that is defined as the rate at which an object changes its velocity. An object is accelerating if it is changing its velocity.";
            }
            else if (formulaInput.Text == "displacement")
            {
                formulaOut.Text = @"Displacement is defined as r.
Distance is a scalar quantity that refers to how much ground an object has covered during its motion. Displacement is a vector quantity that refers to, how far out of place an object is. It is the object's overall change in position.";
            }
            else if (formulaInput.Text == "mass")
            {
                formulaOut.Text = @"m=F/a
In physics, mass is a property of a physical body. It is the measure of an object's resistance to acceleration (a change in its state of motion) when a net force is applied. It also determines the strength of its mutual gravitational attraction to other bodies.";
            }
            else if (formulaInput.Text == "newton's first law" || formulaInput.Text == "law of inertia")
            {
                formulaOut.Text = @"An object at rest stays at rest and an object in motion stays in motion with the same speed and in the same direction unless acted upon by an unbalanced force.";
            }
            else if (formulaInput.Text == "newton's third law")
            {
                formulaOut.Text = @"For every action, there is an equal and opposite reaction.";
            }
            else
            {
                formulaOut.Text = "";
            }
        }

        private void launchCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
