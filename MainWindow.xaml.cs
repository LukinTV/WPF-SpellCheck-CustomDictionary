using System.Printing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_SpellCheck_CustomDictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtSpellCheck.Language = System.Windows.Markup.XmlLanguage.GetLanguage("de-DE");
            txtSpellCheck.SpellCheck.CustomDictionaries.Clear();
            txtSpellCheck.SpellCheck.CustomDictionaries.Add(new Uri(@"C:\temp\Repro\WPF-SpellCheck-CustomDictionary\custom.lex", UriKind.Absolute));
            txtSpellCheck.SpellCheck.IsEnabled = true;
        }
    }
}