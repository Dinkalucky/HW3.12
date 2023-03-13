using System;

// Presenter

namespace MVP
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.myEvent += new EventHandler(mainWindow_myEvent);
            this.view.myEvent += new EventHandler(Add_myEvent);
            this.view.myEvent += new EventHandler(Remove_myEvent);
        }

        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            var data = this.view.textBox1.Text;

            string variable = model.Logic(data);

            this.view.textBox1.Text = variable;
        }
        void Add_myEvent(object sender, System.EventArgs e)
        {
            var data = this.view.textBox1.Text;

            string variable = model.Logic(data);

            this.view.textBox1.Text += "Add";
        }
        void Remove_myEvent(object sender, System.EventArgs e)
        {
            this.view.myEvent -= new EventHandler(mainWindow_myEvent);
            var data = this.view.textBox1.Text;
            string variable = model.Logic(data);

            this.view.textBox1.Text = data;
        }
    }
}
