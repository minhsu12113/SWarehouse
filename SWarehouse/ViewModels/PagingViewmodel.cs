using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Brush = System.Windows.Media.Brush;
using Color = System.Windows.Media.Color;


namespace SWarehouse.ViewModels
{
    public class PagingViewmodel : BindableBase
    {
        #region [Variable]
        private int _totalCountItem;
        private int _currentPage;
        private int _skipItem;
        private Visibility _visibilityDotsUp;
        private Visibility _visibilityDotsDown;
        private bool _isEnableBtnPreviousPage;
        private bool _isEnableBtnNextPage;
        private int _totalCountPage;
        private int _gotoNumberPage;
        private int _pageIndex;
        private const int SizePaging = 5;
        private bool _isEnableBtnFirstPage;
        private int _totalCountDisplay;
        private object _selectedCountDisplay;




        public object SelectedCountDisplay
        {
            get { return _selectedCountDisplay; }
            set { _selectedCountDisplay = value; SetCountDisplay(value); OnPropertyChanged(); }
        }
        public int TotalCountDisplay
        {
            get { return _totalCountDisplay; }
            set { _totalCountDisplay = value; OnPropertyChanged(); }
        }
        public bool IsEnableBtnFirstPage
        {
            get => _isEnableBtnFirstPage;
            set
            {
                _isEnableBtnFirstPage = value;
                OnPropertyChanged();
            }
        }
        private int PageIndex
        {
            get
            {
                return _pageIndex;
            }
            set
            {
                _pageIndex = value;
            }
        }
        public int GotoNumberPage
        {
            get => _gotoNumberPage;
            set
            {
                _gotoNumberPage = value;
                OnPropertyChanged();
            }
        }
        public int TotalCountPage
        {
            get => _totalCountPage;
            set
            {
                _totalCountPage = value;
                OnPropertyChanged();
            }
        }
        public bool IsEnableBtnNextPage
        {
            get => _isEnableBtnNextPage;
            set
            {
                _isEnableBtnNextPage = value;
                OnPropertyChanged();
            }
        }
        public bool IsEnableBtnPreviousPage
        {
            get => _isEnableBtnPreviousPage;
            set
            {
                _isEnableBtnPreviousPage = value;
                OnPropertyChanged();
            }
        }
        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;

                // Trường hợp hiển thị DotsDown
                if (CurrentPage >= SizePaging)
                    VisibilityDotsDown = Visibility.Visible;

                // Trường hợp ẩn DotsDown
                if (CurrentPage <= SizePaging || CurrentPage == 1)
                    VisibilityDotsDown = Visibility.Collapsed;

                // Trường hợp hiển thị DotsUp
                if (TotalCountPage > SizePaging)
                    VisibilityDotsUp = Visibility.Visible;

                // Trường hợp đến Page cuối cùng
                if (CurrentPage == TotalCountPage)
                {
                    VisibilityDotsUp = Visibility.Collapsed;
                    IsEnableBtnNextPage = false;
                }


                OnPropertyChanged();
            }
        }
        public Visibility VisibilityDotsDown
        {
            get => _visibilityDotsDown;
            set
            {
                _visibilityDotsDown = value;
                OnPropertyChanged();
            }
        }
        public Visibility VisibilityDotsUp
        {
            get => _visibilityDotsUp;
            set
            {
                _visibilityDotsUp = value;
                OnPropertyChanged();
            }
        }
        public int TotalCountItem
        {
            get
            {
                return _totalCountItem;
            }
            set
            {
                _totalCountItem = value;
                OnPropertyChanged();
                LoadNumberPage(value);
            }
        }

        #endregion
        #region [Action]
        public Action<int, int> UpdateCollectionCallback
        {
            get; set;
        }
        #endregion
        #region [Collection]
        private ObservableCollection<Pagingner> _pageList;
        private ObservableCollection<String> _countDisplay;

        public ObservableCollection<String> CountDisplay
        {
            get
            {
                return _countDisplay;
            }
            set
            {
                _countDisplay = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Pagingner> PageList
        {
            get
            {
                return _pageList;
            }
            set
            {
                _pageList = value;
                OnPropertyChanged();
            }
        }

        #endregion
        #region [Command]
        public ICommand SelectPageCMD
        {
            get
            {
                return new CommandHelper<Pagingner>((p) => { return p != null; }, SelectPage);
            }
        }
        public ICommand NextPageCMD
        {
            get
            {
                return new CommandHelper(NextPage);
            }
        }
        public ICommand PreviousPageCMD
        {
            get
            {
                return new CommandHelper(PreviousPage);
            }
        }
        public ICommand GotoFirstNumberCMD
        {
            get
            {
                return new CommandHelper(GotoFirstPage);
            }
        }
        public ICommand GotoLastPageCMD
        {
            get
            {
                return new CommandHelper(GotoLastPage);
            }
        }
        #endregion

        public PagingViewmodel(Action<int, int> updateCollectionMethod)
        {
            UpdateCollectionCallback = updateCollectionMethod;
            PageList = new ObservableCollection<Pagingner>();
            LoadOptionDisplay();
            SelectedCountDisplay = CountDisplay[1];           
            PageList = new ObservableCollection<Pagingner>();
            VisibilityDotsDown = Visibility.Collapsed;
        }

        private void LoadNumberPage(int totalItem)
        {
            float round = totalItem / (float)_skipItem;
            decimal totalCountPage = Math.Ceiling((decimal)round);
            if (totalCountPage == 0)
                totalCountPage = 1;
            TotalCountPage = (int)totalCountPage;
            PageList.Clear();

            for (int i = 0; i < totalCountPage; i++)
            {
                Pagingner pagingner = new Pagingner() { PageNumber = i + 1 };
                PageList.Add(pagingner);
                if (i == SizePaging)
                    break;
            }
            CheckLimitPage();
            HandleLogicUI();
            SetColorPagingner(PageList[0]);
        }

        private void ChangeNumberPageToUp(int startPage)
        {
            var listTemp = new List<Pagingner>();
            int j = 1;
            for (int i = startPage; true; i++)
            {
                Pagingner pagingner = new Pagingner() { PageNumber = i };
                listTemp.Add(pagingner);
                if (j == SizePaging || i == _totalCountPage)
                    break;
                j++;
            }
            PageList = new ObservableCollection<Pagingner>(listTemp);
        }

        private void ChangeNumberPageToDown(int startPage)
        {
            // Trường hợp này là khi tạo Page List kiểm tra xem startPage có nhỏ hơn SizePaging không
            if (startPage < SizePaging)
            {
                // Trường hợp tổng Page nhỏ hơn SizePaging
                if (_totalCountPage < SizePaging)
                {
                    startPage = _totalCountPage;
                }
                else
                {
                    startPage = SizePaging;
                }
            }


            var listTemp = new List<Pagingner>();
            int j = 1;
            for (int i = startPage; true; i--)
            {
                Pagingner pagingner = new Pagingner() { PageNumber = i };
                listTemp.Insert(0, pagingner);
                SetColorPagingner(pagingner);
                if (j == SizePaging || i == 1)
                    break;
                j++;
            }
            PageList = new ObservableCollection<Pagingner>(listTemp);
        }

        private void HandleLogicUI()
        {
            var isHaveLastPage = PageList.FirstOrDefault((p) => p.PageNumber == _totalCountPage);
            if (isHaveLastPage != null)
                VisibilityDotsUp = Visibility.Collapsed;
            else
                VisibilityDotsUp = Visibility.Visible;


            var isHaveFirstPage = PageList.FirstOrDefault((p) => p.PageNumber == 1);
            if (isHaveFirstPage != null)
                VisibilityDotsDown = Visibility.Collapsed;
            else
                VisibilityDotsDown = Visibility.Visible;
        }

        private void SetColorPagingner(Pagingner pagingner)
        {
            if (pagingner != null)
            {
                if (pagingner.PageNumber == CurrentPage)
                {
                    SetDefaultColorPagingner();
                    pagingner.Background = new SolidColorBrush(Color.FromRgb(216, 216, 216));
                    pagingner.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                }
            }
        }

        private void SetDefaultColorPagingner()
        {
            PageList?.ToList()?.ForEach(b => { b.Background = System.Windows.Media.Brushes.Transparent; b.Foreground = new SolidColorBrush(Color.FromRgb(19, 84, 138)); });
        }

        private void SelectPage(Pagingner pagingner)
        {
            PageIndex = PageList.IndexOf(pagingner);
            CurrentPage = pagingner.PageNumber;
            UpdateCollectionCallback(CurrentPage - 1, _skipItem);

            SetColorPagingner(pagingner);
            CheckLimitPage();
            HandleLogicUI();


            if (PageIndex == 0 && CurrentPage != 1)
            {
                ChangeNumberPageToDown(CurrentPage);
                PageIndex = PageList.Count == 0 ? 0 : PageList.Count - 1;

                // Xử lý tô màu
                var selectPagingner = PageList.FirstOrDefault((p) => p.PageNumber == CurrentPage);
                SetColorPagingner(selectPagingner);
                HandleLogicUI();
                CheckLimitPage();
                return;
            }


            if (PageIndex == PageList.Count - 1 && _totalCountPage > SizePaging)
            {
                ChangeNumberPageToUp(CurrentPage);
                PageIndex = PageList.Count == 0 ? 0 : PageList.Count - 1;

                // Xử lý tô màu
                var selectPagingner = PageList.FirstOrDefault((p) => p.PageNumber == CurrentPage);
                SetColorPagingner(selectPagingner);
                HandleLogicUI();
                CheckLimitPage();
                return;
            }
        }

        private void NextPage()
        {
            PageIndex += 1;
            CurrentPage += 1;

            // Trường hợp PageIndex ở chỉ mục cuối của PageList
            if (PageIndex == PageList.Count - 1 && _totalCountPage > SizePaging)
            {
                // Thay đổi danh sách nút chuyển Page
                ChangeNumberPageToUp(CurrentPage);
                PageIndex = 0;
            }

            // Trường hợp Page hiện tại là Page cuối cùng trên tổng Page
            if (CurrentPage == _totalCountPage)
                GotoLastPage();

            // Xử lý tô màu
            var selectPagingner = PageList.FirstOrDefault((p) => p.PageNumber == CurrentPage);
            SetColorPagingner(selectPagingner);

            // Xử lý cập nhật Collection
            UpdateCollectionCallback(CurrentPage - 1, _skipItem);
            CheckLimitPage();
            HandleLogicUI();
        }

        private void PreviousPage()
        {
            int pageIndex = PageIndex == 0 ? 0 : PageIndex -= 1;
            PageIndex = pageIndex;
            CurrentPage -= 1;

            // Trường hợp PageIndex ở chỉ mục cuối của PageList
            if (PageIndex == 0 && CurrentPage != 1)
            {
                // Thay đổi danh sách nút chuyển Page              
                ChangeNumberPageToDown(CurrentPage);
                var selectPage = PageList.FirstOrDefault((p) => p.PageNumber == CurrentPage);
                PageIndex = PageList.IndexOf(selectPage);
            }

            // Xử lý cập nhật Collection
            UpdateCollectionCallback(CurrentPage - 1, _skipItem);
            CheckLimitPage();

            // Xử lý tô màu
            var selectPagingner = PageList.FirstOrDefault((p) => p.PageNumber == CurrentPage);
            SetColorPagingner(selectPagingner);
            HandleLogicUI();
        }

        private void CheckLimitPage()
        {
            IsEnableBtnNextPage = CurrentPage < _totalCountPage;
            IsEnableBtnPreviousPage = CurrentPage > 1;
        }

        public void GotoFirstPage()
        {
            ChangeNumberPageToUp(1);
            CurrentPage = 1;
            PageIndex = 0;
            UpdateCollectionCallback(CurrentPage - 1, _skipItem);
            SetColorPagingner(PageList[0]);

            // Trường hợp ẩn DotsDown
            if (CurrentPage <= SizePaging)
                VisibilityDotsDown = Visibility.Collapsed;

            CheckLimitPage();
        }

        private void GotoLastPage()
        {
            CurrentPage = TotalCountPage;
            UpdateCollectionCallback(CurrentPage - 1, _skipItem);
            ChangeNumberPageToDown(CurrentPage);
            PageIndex = PageList.Count == 0 ? 0 : PageList.Count - 1;
            var selectPagingner = PageList.FirstOrDefault((p) => p.PageNumber == CurrentPage);
            SetColorPagingner(selectPagingner);
            CheckLimitPage();
            HandleLogicUI();
        }

        private void LoadOptionDisplay()
        {
            CountDisplay = new ObservableCollection<string>();
            CountDisplay.Add("ALL");
            CountDisplay.Add("20");
            CountDisplay.Add("40");
            CountDisplay.Add("60");
            CountDisplay.Add("80");
            CountDisplay.Add("100");
        }

        private void SetCountDisplay(object obj)
        {
            if (obj.ToString() == "ALL")
            {
                _skipItem = TotalCountItem;
            }
            else
            {
                _skipItem = int.Parse(obj.ToString());
            }

            if (TotalCountItem <= _skipItem)
            {
                TotalCountDisplay = TotalCountItem;
            }
            else
            {
                TotalCountDisplay = _skipItem;
            }
           
            LoadNumberPage(TotalCountItem);
            GotoFirstPage();
        }
    }
    public class Pagingner : BindableBase
    {
        private int _pageNumber;
        private Brush _backGround;
        private Brush _foreground;




        public Brush Foreground
        {
            get => _foreground;
            set { _foreground = value; OnPropertyChanged(); }
        }
        public Brush Background
        {
            get => _backGround;
            set { _backGround = value; OnPropertyChanged(); }
        }
        public int PageNumber
        {
            get => _pageNumber;
            set { _pageNumber = value; OnPropertyChanged(); }
        }
        public Pagingner()
        {
            Foreground = new SolidColorBrush(Color.FromRgb(19, 84, 138));
            Background = System.Windows.Media.Brushes.Transparent;
        }
    }
}
