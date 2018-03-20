/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Wing.DesignPattern"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Wing.DesignPattern.ViewModel.CreationalPatterns;

namespace Wing.DesignPattern.ViewModel
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary>
	public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
			SimpleIoc.Default.Register<SingletonViewModel>();
			SimpleIoc.Default.Register<FactoryMethodViewModel>();
			SimpleIoc.Default.Register<AbstractFactoryViewModel>();
			SimpleIoc.Default.Register<SimpleFactoryViewModel>();
		}

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

		public SingletonViewModel Singleton
		{
			get
			{
				return ServiceLocator.Current.GetInstance<SingletonViewModel>();
			}
		}

		public FactoryMethodViewModel FactoryMethod
		{
			get
			{
				return ServiceLocator.Current.GetInstance<FactoryMethodViewModel>();
			}
		}

		public AbstractFactoryViewModel AbstractFactory
		{
			get
			{
				return ServiceLocator.Current.GetInstance<AbstractFactoryViewModel>();
			}
		}

		public SimpleFactoryViewModel SimpleFactory
		{
			get
			{
				return ServiceLocator.Current.GetInstance<SimpleFactoryViewModel>();
			}
		}

		public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}