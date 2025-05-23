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

namespace WPF_00_Studying
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //// ListBox - Data Binding
            //List<Animals> animals = new List<Animals>();
            //{
            //    new Animals() { Name = "사자", percent = 10 };
            //    new Animals() { Name = "호랑이", percent = 20 };
            //    new Animals() { Name = "코끼리", percent = 30 };
            //}

            //imgTest.Source = new BitmapImage(new Uri("Assets/Handong.jpg", UriKind.Relative));

        }

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            // 선택된 라디오 버튼 확인
//            string result = "";

//            if (radioMale.IsChecked == true)
//            {
//                result = "남성을 선택했습니다.";
//            }
//            else if (radioFemale.IsChecked == true)
//            {
//                result = "여성을 선택했습니다.";
//            }

//            MessageBox.Show(result);
//        }

//        private void radioMale_Checked(object sender, RoutedEventArgs e)
//        {
//            //MessageBox.Show("남성을 선택", "라디오 선택 결과");
//        }

//        private void radioFemale_Checked(object sender, RoutedEventArgs e)
//        {
//            //MessageBox.Show("여성을 선택", "라디오 선택 결과");
//        }

//        // # Slider 이벤트 - 실시간 값 변화
//        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            if (volumeText != null)
//            {
//                volumeText.Text = $"현재 값: {volumeSlider.Value}";
//            }
//        }

//        private void comboFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            // 선택된 항목 가져오기
//            ComboBoxItem selectedItem = (ComboBoxItem)comboFruits.SelectedItem;
//            // or
//            // ComboBoxItem selectedItem = comboFruits.SelectedItem as ComboBoxItem;

//            // As keyword
//            // - 안전하게 형 변환할 수 있게 도와주는 키워드
//            // - 변환이 실패하면 null을 반환

//            // as ComboBoxItem
//            // - selectedItem이 ComboBoxItem으로 변환 가능하면 변환된 값을 반환
//            // - 변환이 불가능하면 null을 반환

//            if (selectedItem != null)
//            {
//                string selectedFruit = selectedItem.Content.ToString();
//                textResult.Text = $"Selected Fruit: {selectedFruit}";
//            }
//        }

//        private void listColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            ListBoxItem selectedItem = (ListBoxItem)listColors.SelectedItem;
//            // or
//            // ListBoxItem selectedItem = listColors.SelectedItem as ListBoxItem;

//            if (selectedItem != null)
//            {
//                string selectedText = selectedItem.Content.ToString();
//                textSelected.Text = selectedText;
//            }
//        }

//        private void listFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            List<string> selectedFruits = new List<string>();

//            foreach (ListBoxItem item in listFruits.SelectedItems)
//            {
//                selectedFruits.Add(item.Content.ToString());
//            }
//            if (selectedFruits.Count > 0)
//                textSelected.Text = $"Selected Fruits: {string.Join(",", selectedFruits)}";
//        }


//        // 데이터 바인딩용 클래스 생성
//        public class Animals
//        {
//            public string Name { get; set; }
//            public int percent { get; set; }


//        }

//        // #11 Web Browser;
//        private void btnNaver_Click(object sender, RoutedEventArgs e)
//        {
//            webBrowser1.Navigate("https://www.naver.com");
//        }

//        private void btnBack_Click(object sender, RoutedEventArgs e)
//        {
//            if(webBrowser1.CanGoBack)
//            {
//                webBrowser1.GoBack();
//            }
//        }

//        private void btnForward_Click(object sender, RoutedEventArgs e)
//        {
//            if(webBrowser1.CanGoForward)
//            {
//                webBrowser1.GoForward();
//            }
//        }

//        private void Button_Click_1(object sender, RoutedEventArgs e)
//        {
//            imgTest.Source = new BitmapImage(new Uri("Assets/Quakar.png", UriKind.Relative));
//        }

//        // 
//        private void Button_Click_2(object sender, RoutedEventArgs e)
//        {
//            imgTest.Source = new BitmapImage(new Uri("Assets/Quakar.png", UriKind.Relative));
//        }

        private void btnOpenImage_Click(object sender, RoutedEventArgs e)
        {
            // OpenFileDialog 열기
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == true)
            {
                // 선택한 이미지 파일 경로 가져오기
                string filePath = openFileDialog.FileName;
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(filePath, UriKind.Absolute));
                //img.Stretch = Stretch.UniformToFill;
                btnOpenImage.Content = img;
                btnOpenImage.Width = img.Width;
                btnOpenImage.Height = img.Height;
            }
        }
    }
}

#region #1. Tab Control
/*
 웹 브라우저처럼 탭 버튼 눌러 다른 내용의 화면 전환.

 1) TabControl : 전체 탭 컨테이너
 2) TabItem : 탭 요소들
    - Header : 탭의 제목
    - Content : 탭의 내용
 */
#endregion

#region # 도구 상자 (Layout Panel)
/*
    1. Grid : 행과 열로 나누어 배치 / 정렬 + 반응형에 최적화
    2. StackPanel : 수직 또는 수평으로 순차적으로 배치 / 간단한 정렬
    3. WrapPanel : 수평 또는 수직으로 배치 / 공간이 부족하면 다음 줄로 이동
    4. DockPanel : 상하좌우에 배치 / 남은 공간에 자동으로 배치
    5. UniformGrid : 행과 열을 균일하게 나누어 배치 / 정렬
    6. Canvas : 절대 좌표로 배치 / 정렬
    7. Viewbox : 자식 요소를 확대 / 축소하여 배치 / 정렬
    8. Border : 테두리와 배경을 설정하여 배치 / 정렬
    9. ScrollViewer : 스크롤바를 추가하여 배치 / 정렬
    10. GroupBox : 그룹을 설정하여 배치 / 정렬
    11. Expander : 접었다 펼 수 있는 그룹을 설정하여 배치 / 정렬
    12. TabControl : 탭을 설정하여 배치 / 정렬
    13. ToolBar : 도구 모음을 설정하여 배치 / 정렬
    14. StatusBar : 상태 표시줄을 설정하여 배치 / 정렬
    15. Menu : 메뉴를 설정하여 배치 / 정렬
    16. ToolBarTray : 도구 모음 트레이를 설정하여 배치 / 정렬
 */

#endregion

#region #2. StackPanel
/*
    자식 요소를 수직 또는 수평으로 배치하는 레이아웃 패널입니다.
    - Orientation : 수직 또는 수평으로 배치
    - HorizontalAlignment : 수평 정렬
    - VerticalAlignment : 수직 정렬
    - Margin : 여백 설정
    - Padding : 내부 여백 설정
    - Background : 배경색 설정
    - Width, Height : 크기 설정
    - MinWidth, MinHeight : 최소 크기 설정
    - MaxWidth, MaxHeight : 최대 크기 설정
 
 */
#endregion

#region #3. Grid
/*
    행과 열로 나누어 배치하는 레이아웃 패널입니다.
    - RowDefinitions : 행 정의
    - ColumnDefinitions : 열 정의

    - Height : 행 높이 설정 / Width : 열 너비 설정
      Auto : 내부 요소의 크기에 맞게 자동으로 / * : 나머지 공간을 비율로 자동 분배 / 숫자(px) : 고정 크기

    - 언제 사용?
      1) 요소들이 표 형태로 정리되어야 할 때
      2) 요소들이 정확한 위치에 있어야 할 때
      3) 반응형 비율 기반 배치가 필요할 때
 */
#endregion

#region #TextBlock
/*
    텍스트를 화면에 출력해주는 WPF 가장 기본적인
    - 화면 읽기 전용 텍스트를 표시할 때 사용. 사용자가 직접 입력 X
    - 입력은 TextBox에서 가능
*/
#endregion

#region #5. GroupBox
/*
    여러 개의 UI 요소를 하나의 그룹을 묶어주고, 그 그룹에 제목(label)을 붙일 수 있는 Container
    서로 관련된 항목들을 시각적으로 묶어 표현할 때 사용
 */
#endregion

#region #6. RadioButton
/*
    [속성]
    1. GroupName : 라디오 버튼 그룹 이름
    2. IsChecked : 체크 여부
    3. Checked : 체크 이벤트
*/
#endregion

#region #7. Slider
/*
    사용자가 드래그하거나 클릭해서 숫자 값을 조절할 수 있도록 해주는 입력 컨트롤 : 음량, 밝기, 비율 조절 등
    [속성]
    1. Minimum : 최소값
    2. Maximum : 최대값
    3. Value : 현재값
    4. Orientation : 방향 (Horizontal, Vertical)
    5. TickFrequency : 눈금 간격
    6. IsSnapToTickEnabled : 눈금에 맞추기 여부
    7. Ticks : 눈금 위치를 직접 설정 
 */
#endregion

#region #8. CheckBox
/*
    여러 항목 복수 선택 가능
    [속성]    
    1. IsChecked : 체크 여부
    2. Content : 체크박스에 표시할 내용
    3. Checked : 체크 이벤트
    4. Unchecked : 체크 해제 이벤트
    5. ThreeState : 체크박스가 세 가지 상태를 가질 수 있도록 설정 (Checked, Unchecked, Indeterminate)
    6. IsThreeState : 세 가지 상태를 가질 수 있는지 여부
    7. GroupName : 체크박스 그룹 이름
    8. ContentTemplate : 체크박스에 표시할 내용의 템플릿
    9. ContentTemplateSelector : 체크박스에 표시할 내용의 템플릿 선택기
    10. ContentStringFormat : 체크박스에 표시할 내용의 문자열 형식
    11. ContentStringFormatSelector : 체크박스에 표시할 내용의 문자열 형식 선택기
 
 */
#endregion


#region #9. ComboBox
/*
    드롭다운 목록에서 항목을 선택할 수 있는 컨트롤
    [속성]
    1. IsEditable : 사용자가 직접 입력할 수 있는지 여부
    2. IsTextSearchEnabled : 텍스트 검색 기능 사용 여부
    3. IsTextSearchCaseSensitive : 대소문자 구분 여부
    4. IsTextSearchTextPath : 텍스트 검색 경로
    5. IsTextSearchTextPathSelector : 텍스트 검색 경로 선택기
 */

#endregion


#region #10. ListBox
/*
    여러 개의 항목들을 목록 형태로 나열해 보여줌
    사용자가 항목을 하나 이상 선택할 수 있도록 해주는 컨트롤
    - ComboBox와 비슷하지만, ComboBox는 드롭다운 목록으로 보여주고(공간 절약) ListBox는 펼쳐진 채로 보여줌(한눈에 보기 좋음)
    [속성]
    1. Items: 항목을 직접 추가할 수 있음
    2. ItemsSource : 외부 데이터 리스트를 바인딩할 수 있음
    3. SelectedItem : 현재 선택된 항목 (기본 단일 선택)
    4. SelectedItems : 현재 선택된 항목들 (다중 선택)
    5. SelectedValue : 현재 선택된 항목의 값
    6. SelectedMode : 선택 모드 (Single, Multiple, Extended)

    [이벤트]
    1. SelectionChanged : 항목이 선택되거나 해제될 때 발생하는 이벤트
 */

/* 데이터 바인딩
    1. ItemsSource : 외부 데이터 리스트를 바인딩할 수 있음
      - ListBox, ComboBox처럼 여러 항목을 보여주는 컨트롤에 데이터를 바인딩(연결)해주는 속성
      - 역할: 연결한 리스트ㅢ 각 항목이 ListBox 안에 자동으로 하나씩 표시됨.
    2. ItemTemplate : 항목의 템플릿을 설정할 수 있음
      - 데이터 바인딩 시 각 항목을 어떤 UI로 표현할지 정의하는 템플릿
    3. DataTemplate
      - ItemTemplate 속성
      - ListBox에서 각 항목이 어떻게 보일지 정의하는 템플릿
      - 기본적으로 항목이 ToString() 값으로 표시되지만,
        DataTemplate을 사용하면, 항목마다 원하는 UI 요소를 조합해서 출력할 수 있음.

    4. {Binding Name }
      - 바인딩된 데이터의 Name 속성 값을 UI에 표시
      - 바인딩된 데이터의 Percent 값을 꺼내서 ProgressBar의 Value로 넣는 것.
 */
#endregion


#region #11. Web Browser
/*
    Internet Explorer를 사용하여 웹 페이지를 표시하는 컨트롤
    Edge 기반 WebView2 컨트롤을 사용하여 웹 페이지를 표시하는 것이 좋음

    Why? 

    [속성]
    1. Source : 웹 페이지 URL
 */
#endregion

#region # Advanced Usage
#endregion

#region #1. Image
/*
    WPF에서 사진, 아이콘, 일러스트 등 Bitmap 기반 이미지 리소스를 렌더링
    내부적으로는 System.Windows.Controls.Image 클래스

    [이미지 파일 관리]
    - Assets : 가장 보편적이고 시각적인 리소스 포함하는 느낌
    - Images : 이미지 전용 폴더로 직관적이다.

    [속성]
    - Source : 이미지 파일 경로 or Uri
    - Stretch : 이미지 크기 조절 방식
        1) None : 원본 크기 유지
        2) Fill : 원본 비율 무시하고 Stretch
        3) Uniform : 원본 비율 유지하며 Stretch
        4) UniformToFill : 원본 비율 유지하며 Stretch, 남는 부분은 잘림
 */
#endregion

#region Image Build 방식
/*
    1) Resource 방식
        - image 파일을 실행 프로그램(.exe)에 포함시켜 배포하는 방식 (즉, 프로그램 안에 이미지가 포함되어 있는 형태라서 외부 파일을 따로 챙길 필요가 없음)
        - 수정은 불가능하지만, 정적인 리소스(아이콘, 배경, 버튼 등)에 매우 적합하다!

        [특징]
        - 배포 간편
        - 수정 불가능, 정적인 리소스에 적합
        - 경로 문제 없음
        - 유지보수 용이

        [방법]
        1) 이미지 파일을 프로젝트에 추가
        2) 속성창에서 Build Action을 Resource로 설정
        ** 출력 디렉토리에 복사할 필요 없음.
        3) XAML 또는 C# 코드에서 사용한다. Source="파일명"으로 사용 가능 : VS 프로젝트 기준 상대경로로 동작한다.

    2) Content 방식
        - 이미지 파일을 실행 파일(.exe)이 있는 폴더에 ㅂㄱ사해 놓고, 거기서 직접 불러오는 방식

        [When?]
        - 사용자 이미지 업로드할 때

        [특징]
        - 실행 파일 외부에 따로 존재하는 이미지
        - 프로그램이 실행될 때 이미지 파일을 같이 복사해서 사용하는 구조
 
        [방법]
        1) 이미지 파일을 프로젝트에 추가
        2) 속성창에서 Build Action을 Content로 설정
           - 빌드 작업(Build Action) : Content
           - 출력 디렉토리에 복사(Copy to Output Directory) : Copy if newer (권장)

*/
#endregion