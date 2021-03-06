
using System.Threading.Tasks;
using Xamarin.Forms;
using Spoodi.Models.ViewModels;
using Spoodi.Controls;
using System;
using Spoodi.ViewModels;
using Xamarin.CommunityToolkit.UI.Views;

namespace Spoodi.Views
{
    public partial class HomePage : BasePage
    {
        public HomePage()
        {
            InitializeComponent();
            SizeChanged += MainPage_SizeChanged;
        }
        Storyboard _storyboard = new Storyboard();

        const int margin = 20;
        const int animationSpeed = 250;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ScrollContainer.Scrolled += ScrollContainer_Scrolled;
        }


        private async void ScrollContainer_Scrolled(object sender, ScrolledEventArgs e)
        {
            /* if ((e.ScrollY > 0) && (CurrentState != States.SearchHidden))
             {
                 _storyboard.Go(States.SearchHidden);
                 CurrentState = States.SearchHidden;
                 ScrollContainer.IsEnabled = false;
                 await Task.Delay(animationSpeed);
                 ScrollContainer.IsEnabled = true;
             }
             else if ((e.ScrollY == 0) && (CurrentState != States.SearchExpanded))
             {
                 _storyboard.Go(States.SearchExpanded);
                 CurrentState = States.SearchExpanded;
                 ScrollContainer.IsEnabled = false;
                 await Task.Delay(animationSpeed);
                 ScrollContainer.IsEnabled = true;
             }*/
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {/*

            _storyboard = new Storyboard();
            var width = this.Width;
            var height = this.Height;

            // shopping cart
            Rectangle basketRect = new Rectangle(
                x: width - (BasketIcon.Width + margin),
                y: margin,
                width: BasketIcon.Width,
                height: BasketIcon.Height
                );
            AbsoluteLayout.SetLayoutBounds(BasketIcon, basketRect);
        
       // search icon
            Rectangle searchRect = new Rectangle(
                x: margin,
                y: 200,
                width: SearchIcon.Width,
                height: SearchIcon.Height
                );
        AbsoluteLayout.SetLayoutBounds(SearchIcon, searchRect);
*//*

            Rectangle searchRectCollapsed = new Rectangle(
                x: BasketIcon.Bounds.Left - (margin + SettingsIcon.Width + margin + SearchIcon.Width),
                y: margin,
                width: SearchIcon.Width,
                height: SearchIcon.Height
            );

        // settings icon
        Rectangle settingsRect = new Rectangle(
            x: width - (SettingsIcon.Width + margin),
            y: 200,
            width: SettingsIcon.Width,
            height: SettingsIcon.Height
            );
        AbsoluteLayout.SetLayoutBounds(SettingsIcon, settingsRect);

            Rectangle settingsRectCollapsed = new Rectangle(
                x: BasketIcon.Bounds.Left - (margin + SettingsIcon.Width),
                y: margin,
                width: SettingsIcon.Width,
                height: SettingsIcon.Height
                );*/



            /*    Rectangle searchBackgroundRect = new Rectangle(
                    x: margin,
                    y: 200,
                    width: SettingsIcon.Bounds.X - (margin + margin),
                    height: SearchBackground.Height
                    );*//*
                AbsoluteLayout.SetLayoutBounds(SearchBackground, searchBackgroundRect);

                   *//* Rectangle searchBackgroundCollapsedRect = new Rectangle(
                        x: BasketIcon.Bounds.Left - (margin + SettingsIcon.Width + margin + SearchIcon.Width),
                        y: margin,
                        width: SettingsIcon.Width,
                        height: SettingsIcon.Height
                    );*//*


                // ScrollContainer
                Rectangle scrollContainerRect = new Rectangle(
                    x: margin,
                    y: SearchIcon.Bounds.Bottom + margin,
                    width: width - (2 * margin),
                    height: height - (SearchIcon.Bounds.Bottom + margin)
                    );
                AbsoluteLayout.SetLayoutBounds(ScrollContainer, scrollContainerRect);

                    Rectangle scrollContainerRectCollapsed = new Rectangle(
                        x: margin,
                        y: margin + BasketIcon.Height + margin,
                        width: width - (2 * margin),
                        height: height - (margin + BasketIcon.Height + margin)
                        );

                // add the positions to the state machine
                _storyboard.Add(States.SearchExpanded, new[]
                    {
                        new ViewTransition(Header, AnimationType.Opacity, 1, animationSpeed),
                        new ViewTransition(SearchEntry, AnimationType.Opacity, 1, animationSpeed),
                       // new ViewTransition(SettingsIcon, AnimationType.Layout, settingsRect, animationSpeed),
                        new ViewTransition(SearchIcon, AnimationType.Layout, searchRect, animationSpeed),
                        new ViewTransition(SearchBackground, AnimationType.Layout, searchBackgroundRect, animationSpeed),
                        new ViewTransition(ScrollContainer, AnimationType.Layout, scrollContainerRect, animationSpeed)
                    });

                    _storyboard.Add(States.SearchHidden, new[]
                    {
                        new ViewTransition(Header, AnimationType.Opacity, 0.01, animationSpeed),
                        new ViewTransition(SearchEntry, AnimationType.Opacity, 0.01),
                       // new ViewTransition(SettingsIcon, AnimationType.Layout, settingsRectCollapsed, animationSpeed),
                        new ViewTransition(SearchIcon, AnimationType.Layout, searchRectCollapsed, animationSpeed),
                        new ViewTransition(SearchBackground, AnimationType.Layout, searchBackgroundCollapsedRect, animationSpeed),
                        new ViewTransition(ScrollContainer, AnimationType.Layout, scrollContainerRectCollapsed, animationSpeed)
                    });*/
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            SizeChanged -= MainPage_SizeChanged;
        }

       

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

        }

        /*   States CurrentState = States.SearchExpanded;*/


        //Term ccomment hamburger
        //private void HamburgerButton_Clicked(object sender, EventArgs e)
        //{
        //    ProfilePopover.IsVisible = true;
        //}

        //private void Handle_Tapped(object sender, EventArgs e)
        //{
        //    MasterDetailPage nav = new MasterDetailPage();
        //    nav.IsPresented = true;
        //}
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // the user has tapped on an element
            ProductDisplay element = sender as ProductDisplay;

            // set the binding context to the selected cell
            FakeProductCell.BindingContext = element.BindingContext;
            FakeProductCell.ImageOffsetX = element.ImageOffsetX;
            FakeProductCell.ImageOffsetY = element.ImageOffsetY;
            FakeProductCell.Opacity = 1;
            FakeProductCell.IsVisible = true;

            // set the selected item
            ((MainTermPageViewModel)this.BindingContext).SelectedProduct = element.BindingContext as ProductViewModel;

            // set the layout to the same postion
            var yScroll = ScrollContainer.ScrollY;
            Rectangle rect = new Rectangle(
                x: ScrollContainer.X + element.X,
                y: ScrollContainer.Y + element.Y - yScroll,
                width: element.Width,
            height: element.Height);
            AbsoluteLayout.SetLayoutBounds(FakeProductCell, rect);

            // hide the cell we clicked on
            element.Opacity = 0.01;
            await FakeProductCell.ExpandToFill(this.Bounds);
            element.Opacity = 1;

            // display the page popover
            PagePopover.Opacity = 0;
            PagePopover.IsVisible = true;
            var grid = FindByName("FakeGrid") as Grid;
            grid.HeightRequest = 600;
            await PagePopover.Expand();

        }

        public void OnLeftButtonClicked(object? sender, EventArgs e)
            => SideMenuView.State = SideMenuState.LeftMenuShown;

        public void OnLeftLinkClicked(object? sender, EventArgs e)
           => SideMenuView.State = SideMenuState.MainViewShown;

        public void OnRightButtonClicked(object? sender, EventArgs e)
            => SideMenuView.State = SideMenuState.RightMenuShown;
        internal async Task HidePopover()
        {

            // fade out the elements
            await Task.WhenAll(
                new Task[]
                {
                    FakeProductCell.FadeTo(0),
                    PagePopover.FadeTo(0)
                });

            // hide our fake product cell
            FakeProductCell.IsVisible = false;

            // hide our Page poper
            PagePopover.IsVisible = false;
            var grid = FindByName("FakeGrid") as Grid;
            grid.HeightRequest = 0;
        }



        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            ((View)sender).IsVisible = false;
        }

        private void ProductDisplay_AddToCartClicked(object sender, EventArgs e)
        {
            // selected product
            ProductDisplay element = sender as ProductDisplay;
            ProductViewModel item = element.BindingContext as ProductViewModel;

            // add a shopping card item
            ((MainTermPageViewModel)this.BindingContext).ShoppingCart.IncrementOrder(item);

        }

        private void BasketIcon_Clicked(object sender, EventArgs e)
        {
            CartPopover.IsVisible = true;
        }

    }
}
