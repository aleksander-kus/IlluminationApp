using System.Windows.Forms;

namespace PresentationLayer
{
    class FillViewLoader : IViewLoader
    {
        private Form loadedView;
        public Form LoadedView { get => loadedView; }

        public void LoadFillView()
        {
            FillWindow view = new();
            FillPresenter presenter = new(view);

            view.Presenter = presenter;

            LoadView(view);
        }

        private void LoadView(Form view)
        {
            view.Show();
            loadedView = view;
        }
    }
}
