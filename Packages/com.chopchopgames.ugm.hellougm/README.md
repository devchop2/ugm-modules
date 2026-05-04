# Hello UGM

UGM E2E 검증용 더미 모듈입니다.

## 사용법

1. UGM 창에서 이 모듈을 Install
2. 씬에 빈 GameObject 만들기
3. `Add Component` → `Hello UGM` 검색 → 추가
4. PlayMode 진입 → Console에 `[UGM:HelloUGM] Hello UGM! ...` 로그 출력

## 검증하는 것

- UGM 카탈로그 → GitHub Release zip 다운로드 → 압축 해제 → `Packages/com.chopchopgames.ugm.hellougm/` 임베디드 패키지 등록 흐름이 정상 작동
- UPM 어셈블리(`ChopChopGames.UGM.HelloUGM.dll`)가 컴파일되어 사용자 씬에서 즉시 사용 가능

## namespace

```csharp
using ChopChopGames.UGM.HelloUGM;
```
