namespace Utility.Views
{
    public interface IInjectableViewController<T> where T : IInjectableView
    {
        void SetView(T view);
    }
}