using System.Timers;
using TestClickApplication.ClickApi;
using TestClickApplication.OS;

namespace TestClickApplication.UI
{
    public partial class Form1 : Form
    {
        public SystemObserver observer;
        public ApiService apiService;
        private FormModel formModel;
        public Form1(SystemObserver observer, ApiService apiService)
        {
            this.observer = observer;
            this.apiService = apiService;
            InitializeComponent();
            BindData();
            PollClicks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected void BindData()
        {
            formModel = new FormModel(this);
            clickNumber.DataBindings.Add(new Binding("Text", formModel, "ClickCount"));
            refreshText.DataBindings.Add(new Binding("Text", formModel, "RefreshedOn"));
        }

        #region Functionality on the form
        /// <summary>
        /// TODO: this is a dummy counter that just pretends the timer is 
        /// </summary>
        protected void PollClicks()
        {
            var timer = new System.Timers.Timer();
            timer.Elapsed += (object sender, ElapsedEventArgs e) => {
                formModel.ClickCount = formModel.ClickCount + 1;
                formModel.RefreshedOn = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            };
            timer.Interval = 3000;
            timer.Start();
        }

        #endregion
    }
}