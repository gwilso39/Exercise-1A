using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;//I added this using statement thinking I may use it to display a window.

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Excercise_1A_Mathematical_Formulas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void okGoCircle(object sender, RoutedEventArgs e)
        {
            double cirRad = int.Parse(circleRadius.Text);
            double pi = 3.14159;
            double circumOutcome = (2) * pi * cirRad;
            double areaOutcome = pi * (cirRad * cirRad);
            answerCircum.Text = circumOutcome.ToString();
            answerArea.Text = areaOutcome.ToString();
        }

        private void okGoHemi(object sender, RoutedEventArgs e)
        {
            double hRad = int.Parse(hemiRadius.Text);//This will convert the captured varisble to a number to be used in calculations.
            double hemiOutcome = 0;//This is establishing and setting the variable hemiOutcome to zero.
            double pi = 3.14159;//This establishes the variable pi appropriately.
            hemiOutcome = ((2) * pi * (hRad*hRad*hRad))/(3);//I didn't know how to cube a number.
            answerHemiVol.Text = hemiOutcome.ToString();//completing the math - this converts back to text and displays the answer.
        }

        private void okGoAreaTri(object sender, RoutedEventArgs e)
        {
            double aSide = int.Parse(sideA.Text);
            double bSide = int.Parse(sideB.Text);
            double cSide = int.Parse(sideC.Text);
            double pHalf = 0;
            pHalf = (aSide + bSide + cSide) / (2);
            double triArea = 0;
            triArea = Math.Sqrt(pHalf * (pHalf - aSide) * (pHalf - bSide) * (pHalf - cSide));
            answerAreaTri.Text = triArea.ToString();
        }

        private void okGoQuad(object sender, RoutedEventArgs e)
        {
            double quadA = int.Parse(coA.Text);
            double quadB = int.Parse(coB.Text);
            double quadC = int.Parse(coC.Text);
            double variableX1 = 0;
            double variableX2 = 0;
            variableX1 = (-quadB  +  (Math.Sqrt((quadB * quadB) - (4 * quadA * quadC))))   / (2 * quadA);
            variableX2 = (-quadB  -  (Math.Sqrt((quadB * quadB) - (4 * quadA * quadC))))   / (2 * quadA);         
            answerQuad.Text = (variableX1.ToString())+" or "+(variableX2.ToString());
        }
    }
}
