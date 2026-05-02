# ugm-modules

UGM(Unity Game Maker) 모듈 카탈로그.

UGM 에디터 창은 이 저장소의 `registry.json`을 raw URL로 fetch해서 모듈 목록을 표시하고, 사용자가 Import 버튼을 누르면 각 모듈의 `files`에 명시된 파일을 raw URL로 다운로드한다.

## 구조

```
ugm-modules/
├── registry.json                ← 카탈로그 진입점 (UGM이 fetch)
└── modules/
    └── <ModuleId>/              ← 모듈 폴더
        └── Scripts/...
```

## 새 모듈 추가하기

1. `modules/<ModuleId>/` 폴더 생성 후 스크립트·에셋 추가
2. `registry.json` 의 `modules` 배열에 항목 한 개 추가:
   ```json
   {
     "id": "<module-id>",
     "displayName": "<표시 이름>",
     "version": "0.1.0",
     "description": "<설명>",
     "path": "modules/<ModuleId>",
     "files": [
       "Scripts/Foo.cs",
       "Prefabs/Bar.prefab"
     ],
     "dependencies": [],
     "sdks": []
   }
   ```
3. `updatedAt` 을 오늘 날짜로 갱신
4. push → UGM 사용자들의 창에 즉시 반영됨 (UGM 재설치 불필요)

## 모듈 제거하기

- `registry.json` 의 해당 항목 삭제 + `modules/<ModuleId>/` 폴더 삭제 → push
- 이미 임포트한 사용자의 `Assets/UGM/<id>/` 는 영향 없음 (수동 삭제 필요)

## raw URL 형식

```
https://raw.githubusercontent.com/devchop2/ugm-modules/main/registry.json
https://raw.githubusercontent.com/devchop2/ugm-modules/main/modules/<ModuleId>/<file>
```
