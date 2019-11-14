# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
## [Unreleased]


## [0.0.992] - 2019-11-14
### Updated
- 2d singleton game editorwindow - three columns; update text for infrastructure related info
- CHANGELOG.md
- package.json - update version to 0.0.992
### Deleted
- Assets folder content from development. 




## [0.0.991] - 2019-11-13
### Updated
- added dependcy to package.json for tmpro
### Added
- uimanager, ilevel, levelmanager code for singleton. (unimplemented)
### Fixed
- UI. gather layout and texture aranagement 
- MenuItem (added simuframework/windows/singleton/2d) as true; others as false. placefolder for other architectures. 
### Moved 
- CreateLevel2dEditorWindow to Editor/Archive
- CreateProjectFoldersEditorWindow to Editor/Archive
- CreateSceneEditorWindow to Editor/Archive
- MyWindow to Editor/Archive
- SimuframeworkWindow to Editor/Archive
- SimuframeworkSimulatorWindow to Editor/Archive
- ArchitectureEditorWindow, InfrastructureEditorWindow, WorkCycleEditorWindow moved to Editor/Windows/Help folder
- Editor/MenuItem
- Editor/Windows/Workflow
- Editor/UilityToolkit

### Updated
- Menu Item
- Internal Dev Folder Strutucture
- todo
- CHANGELOG.md
- Singleton.cs
- GameManagerSingleton.cs




## [0.0.99] - 2019-11-3
### Major changes
- Revisioned the app to be more inclusive to the original design of Unity Editor. Not as many windows will be present to complete and automate tasks relating to adding gameobjects to the scenecs; adding or changing assets withinin the assest folder. 
### Updated
- change.md
- quicksomething

### Removed
- quicksomething and added it verison_planning



## [0.0.7] - 2019-10-17
### Added
- added documentation folder to simuframework-dev project for git command history. 
- added mvc code and namespace simuframework.mvc.infrassctructure
- added files up data on git commands protocol 
- added todo file 
### Updated
- Updated Changelog
- Updated package.json (version 0.0.6 to 0.0.7)
- Updated Todo
### Changed
- Changed button for creating main scene. 


## [0.0.6] - 2019-10-16
### Added
- Added Changelog.md, Third Party Notices.md, QAReport.md 
- Added folder documentation~ 
- Added simuframework.md to documentation

### Changed
- Changed the names for the assembly definition files for test, editor, and runtime. also added place holder for editor and runtime tests in test folder.

## [0.0.5] - 2019-10-16
### This is the first before changelog documented for simuframework, as a Package

## [CHANGELOG Types] - 2019-10-16
### Added
- for new features. 
### Changed
- for changes in existing functionality. 
### Deprecated
- for soon-to-be removed features. 
### Removed
- for now removed features. 
### Fixed
- for any bug fixes. 
### Security
- in case of vulnerabilities. 