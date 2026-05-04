# ugm-modules

UGM(Unity Game Maker) **모듈 카탈로그**. 이 레포는 `registry.json` 한 파일이 핵심이고, 실제 모듈 코드는 각 모듈 전용 레포에 있습니다.

## 구조

```
ugm-modules/
├── registry.json     ← UGM 클라이언트가 raw URL로 fetch하는 카탈로그
└── README.md
```

## 모듈 레포 (별도 저장소)

| 모듈 ID | 패키지 이름 | 레포 |
|---|---|---|
| hellougm | com.chopchopgames.ugm.hellougm | [ugm-mod-hellougm](https://github.com/devchop2/ugm-mod-hellougm) |
| googlesheettable | com.chopchopgames.ugm.googlesheettable | [ugm-mod-googlesheettable](https://github.com/devchop2/ugm-mod-googlesheettable) |

각 모듈 레포는 독립된 git 히스토리·issues·releases를 가집니다. 모듈을 수정하려면 해당 레포만 clone해서 작업하면 됩니다.

## UGM 코어

[devchop2/ugm](https://github.com/devchop2/ugm) — Window > UGM > Open으로 이 카탈로그를 fetch하고 모듈을 설치하는 EditorWindow 도구.

```
Add package from git URL: https://github.com/devchop2/ugm.git
```

## 모듈 추가 절차

1. 새 GitHub 레포 생성: `gh repo create devchop2/ugm-mod-<NAME> --public`
2. 모듈 코드를 그 레포에 push (UPM 패키지 형식: 루트에 package.json + Runtime/ + Editor/ ...)
3. v 태그 + Release 생성 (zip 첨부)
4. 본 레포의 registry.json에 새 항목 추가:
   ```json
   {
     "id": "<id>",
     "name": "com.chopchopgames.ugm.<id>",
     "displayName": "...",
     "version": "0.1.0",
     "description": "...",
     "downloadUrl": "https://github.com/devchop2/ugm-mod-<NAME>/releases/download/v0.1.0/<id>-0.1.0.zip",
     "dependencies": [],
     "documentationUrl": "https://github.com/devchop2/ugm-mod-<NAME>"
   }
   ```
5. registry.json commit + push → 사용자 UGM 창에 즉시 반영

## 스키마 버전

`schemaVersion: 2` — UPM 패키지 기반. v1(raw 파일 + Assets/UGM/ 복사 방식)은 폐기됨.

## 작업 사이클 (디스크 절약형)

```powershell
# 카탈로그 갱신할 때
git clone https://github.com/devchop2/ugm-modules.git
# registry.json 편집
git commit -am "..."
git push
# 끝나면 폴더 통째로 삭제
```
