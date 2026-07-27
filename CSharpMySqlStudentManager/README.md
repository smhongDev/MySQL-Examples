# C# + MySQL 학생관리 CRUD 예제

Visual Studio 2022에서 실행할 수 있는 **.NET 8 Windows Forms + MySqlConnector +
MySQL 8** 기초 예제입니다.

## 학습 내용

- MySQL 연결 및 연결 확인
- `SELECT`, `INSERT`, `UPDATE`, `DELETE`
- `DataGridView` 데이터 바인딩
- SQL 매개변수를 이용한 SQL Injection 방지
- `async/await` 비동기 데이터베이스 처리
- Model, Repository, Form의 역할 분리
- 설정 파일을 이용한 연결 문자열 관리

## 준비 환경

- Windows 10 또는 Windows 11
- Visual Studio 2022
  - `.NET 데스크톱 개발` 워크로드
- .NET 8 SDK
- MySQL Server 8.x
- MySQL Workbench

## 실행 순서

### 1. 데이터베이스 만들기

MySQL Workbench에서 관리자 계정으로 접속한 뒤
`database/create_database.sql` 파일을 열어 전체 SQL을 실행합니다.

SQL은 다음 항목을 생성합니다.

- `student_db` 데이터베이스
- `student_app` 실습용 사용자
- `students` 테이블
- 예제 학생 데이터 3건

### 2. 연결 정보 확인하기

`StudentManager/appsettings.json` 파일을 열어 MySQL 환경에 맞게 수정합니다.

```json
{
  "ConnectionStrings": {
    "StudentDb": "Server=localhost;Port=3306;Database=student_db;User ID=student_app;Password=change_me;Character Set=utf8mb4;"
  }
}
```

SQL 파일에서 비밀번호를 변경했다면 여기에도 같은 비밀번호를 입력합니다.
실제 운영 환경에서는 비밀번호를 저장소에 올리지 말고 환경변수나 보안 저장소를
사용해야 합니다.

### 3. Visual Studio에서 실행하기

1. `CSharpMySqlStudentManager.sln`을 엽니다.
2. 솔루션 탐색기에서 솔루션을 마우스 오른쪽 버튼으로 클릭합니다.
3. **NuGet 패키지 복원**을 선택합니다.
4. `F5`를 눌러 실행합니다.

## 폴더 구조

```text
CSharpMySqlStudentManager
├─ CSharpMySqlStudentManager.sln
├─ database
│  └─ create_database.sql
└─ StudentManager
   ├─ Data
   │  ├─ MySqlDatabase.cs
   │  └─ StudentRepository.cs
   ├─ Forms
   │  └─ MainForm.cs
   ├─ Models
   │  └─ Student.cs
   ├─ Program.cs
   ├─ StudentManager.csproj
   └─ appsettings.json
```

## CRUD와 메서드 연결

| 기능 | SQL | Repository 메서드 |
|---|---|---|
| 목록 및 검색 | `SELECT` | `GetAllAsync()` |
| 학생 등록 | `INSERT` | `InsertAsync()` |
| 학생 수정 | `UPDATE` | `UpdateAsync()` |
| 학생 삭제 | `DELETE` | `DeleteAsync()` |

## 수업 진행 권장 순서

1. MySQL 데이터베이스와 테이블 생성
2. NuGet과 MySqlConnector 설명
3. 연결 문자열과 `MySqlConnection`
4. `SELECT`와 `MySqlDataReader`
5. `INSERT`와 매개변수
6. `UPDATE`, `DELETE`
7. `DataGridView` 바인딩
8. 예외 처리와 비동기 처리

## 자주 발생하는 오류

### Access denied for user

`appsettings.json`의 사용자명과 비밀번호를 확인하고,
`create_database.sql`의 `CREATE USER` 및 `GRANT`가 실행됐는지 확인합니다.

### Unable to connect to any of the specified MySQL hosts

MySQL 서비스가 실행 중인지, 포트가 `3306`인지 확인합니다.

### Unknown database 'student_db'

`create_database.sql`을 먼저 실행합니다.

### Duplicate entry

학번에는 UNIQUE 제약조건이 있어 동일한 학번을 두 번 등록할 수 없습니다.

## 확장 실습 아이디어

- 학년과 이메일 열 추가
- 학과를 ComboBox로 변경
- 전화번호 형식 검증
- 페이징 처리
- 로그인 화면 추가
- 트랜잭션 실습
