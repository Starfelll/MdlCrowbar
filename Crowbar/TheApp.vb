Imports System.Globalization

Public Class TheApp

	Public Shared InternalNumberFormat = New CultureInfo("en-US", False)
	Public Shared InternalCultureInfo = InternalCultureInfo.NumberFormat

	Public Shared SmdFileNames As List(Of String)

	Public Shared AnimsSubFolderName = "anims"

	Public Shared Function GetHeaderComment() As String
		Dim line As String

		line = "Created by Crowbar.Net"

		Return line
	End Function

	Public Class Settings
		Public DecompileMdlPathFileName As String
		'Public Shared DecompileOutputFolderOption As OutputFolderOptions
		Public Shared DecompileOutputFolderOption As DecompileOutputPathOptions
		Public Shared DecompileOutputSubfolderName As String
		Public Shared DecompileOutputFullPath As String
		'Public Shared DecompileOutputPathName As String

		Public Shared DecompileQcFileIsChecked As Boolean
		Public Shared DecompileGroupIntoQciFilesIsChecked As Boolean
		Public Shared DecompileQcSkinFamilyOnSingleLineIsChecked As Boolean
		Public Shared DecompileQcOnlyChangedMaterialsInTextureGroupLinesIsChecked As Boolean
		Public Shared DecompileQcIncludeDefineBoneLinesIsChecked As Boolean
		Public Shared DecompileQcUseMixedCaseForKeywordsIsChecked = False

		Public Shared DecompileReferenceMeshSmdFileIsChecked As Boolean
		Public Shared DecompileRemovePathFromSmdMaterialFileNamesIsChecked As Boolean
		Public Shared DecompileUseNonValveUvConversionIsChecked As Boolean

		Public Shared DecompileBoneAnimationSmdFilesIsChecked As Boolean
		Public Shared DecompileBoneAnimationPlaceInSubfolderIsChecked As Boolean

		Public Shared DecompileTextureBmpFileIsChecked As Boolean
		Public Shared DecompileLodMeshSmdFilesIsChecked As Boolean
		Public Shared DecompilePhysicsMeshSmdFileIsChecked As Boolean
		Public Shared DecompileVertexAnimationVtaFileIsChecked As Boolean
		Public Shared DecompileProceduralBonesVrdFileIsChecked As Boolean

		Public Shared DecompileDeclareSequenceQciFileIsChecked As Boolean

		Public Shared DecompileFolderForEachModelIsChecked As Boolean
		Public Shared DecompilePrefixFileNamesWithModelNameIsChecked As Boolean
		Public Shared DecompileStricterFormatIsChecked = False
		Public Shared DecompileLogFileIsChecked As Boolean
		Public Shared DecompileDebugInfoFilesIsChecked As Boolean

		Public Shared DecompileOverrideMdlVersion As SupportedMdlVersion
		Public Shared DecompileMode As InputOptions
		Public Shared DecompilerIsRunning As Boolean
	End Class

	Public Class Resources



	End Class

End Class

