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

#region #2. 도구 상자 (Layout Panel)
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