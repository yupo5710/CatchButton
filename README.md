# 버튼잡기게임(C# 코딩)
## 개요
- C# 프로그래밍 학습
- 핵심기능: 마우스 포인터가 버튼에 갖다댈시 랜덤으로 자동 이동
- 화면구성:<img width="1184" height="750" alt="image" src="https://github.com/user-attachments/assets/8d593fac-ea2e-4f52-896d-7df93bc8745c" />
## 실행 화면
- 1단계 코드의 실행
목표:버튼컨트롤영역안으로마우스가들어가면버튼을랜덤위치로이동
  -내용
  1. UI 구성
  2. 버튼 이동기능구현:랜덤 변수 rd변수 사용해서 x,y좌표가 포인터가 버튼에 들어갈때 사용
  3. 버튼 위치정보표시:this.Text = $"버튼위치: ({nextX}, {nextY})"
  4. 버튼 이동범위제한:this.ClientSize.Width/Height - CatchButton.Width/Height
<img width="1187" height="739" alt="image" src="https://github.com/user-attachments/assets/612f1f23-f533-4c8c-8704-71bc496c53d6" />
- 2단계 코드의 실행 버튼을잡았을때와놓쳤을때적절한피드백을주기
- <img width="1567" height="1037" alt="image" src="https://github.com/user-attachments/assets/c6fa74ef-f2e2-4e9a-be66-76cadcb84486" />
    윈도우 기본 소리로 잡았을때 놓쳤을떄 소리 생성
- 3단계 코드의 실행 점수표시와점수별난이도조정
<img width="773" height="657" alt="image" src="https://github.com/user-attachments/assets/c971a3c9-2120-49bc-a6f6-5d600eb15d16" />

 CatchButton.Width = (int)(CatchButton.Width * 0.9);
CatchButton.Height = (int)(CatchButton.Height * 0.9);
  마우스 클릭에서 잡을때 마다 10퍼센트 감소,왼쪽 상단 좌표 표시
- 4단계 코드의 실행 스크린샷
- <img width="1573" height="965" alt="image" src="https://github.com/user-attachments/assets/29a62a45-f706-4374-a20b-fe8a212f26aa" />
  실패시 게임오버,다시시작 활성화
