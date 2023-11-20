Imports System.Globalization

Public Module Settings


	Public InternalCultureInfo = New CultureInfo("en-US", False)

	Public ReadOnly Property InternalNumberFormat() As NumberFormatInfo
		Get
			Return InternalCultureInfo.NumberFormat
		End Get
	End Property


	Public SmdFileNames As List(Of String)

	Public AnimsSubFolderName = "anims"

	Public Function GetHeaderComment() As String
		Dim line As String

		line = "Created by MdlCrowbar"

		Return line
	End Function

	Public Class DecompilerSettings
		Public DecompileMdlPathFileName = ""
		'Public Shared DecompileOutputFolderOption As OutputFolderOptions
		Public Shared DecompileOutputFolderOption = DecompileOutputPathOptions.WorkFolder
		Public Shared DecompileOutputSubfolderName = "decompiled"
		Public Shared DecompileOutputFullPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		'Public Shared DecompileOutputPathName As String

		Public Shared DecompileQcFileIsChecked = True
		Public Shared DecompileGroupIntoQciFilesIsChecked = False
		Public Shared DecompileQcSkinFamilyOnSingleLineIsChecked = True
		Public Shared DecompileQcOnlyChangedMaterialsInTextureGroupLinesIsChecked = True
		Public Shared DecompileQcIncludeDefineBoneLinesIsChecked = True
		Public Shared DecompileQcUseMixedCaseForKeywordsIsChecked = False

		Public Shared DecompileReferenceMeshSmdFileIsChecked = True
		Public Shared DecompileRemovePathFromSmdMaterialFileNamesIsChecked = True
		Public Shared DecompileUseNonValveUvConversionIsChecked = False

		Public Shared DecompileBoneAnimationSmdFilesIsChecked = True
		Public Shared DecompileBoneAnimationPlaceInSubfolderIsChecked = True

		Public Shared DecompileTextureBmpFilesIsChecked = True
		Public Shared DecompileLodMeshSmdFilesIsChecked = True
		Public Shared DecompilePhysicsMeshSmdFileIsChecked = True
		Public Shared DecompileVertexAnimationVtaFileIsChecked = True
		Public Shared DecompileProceduralBonesVrdFileIsChecked = True

		Public Shared DecompileDeclareSequenceQciFileIsChecked = False

		Public Shared DecompileFolderForEachModelIsChecked = False
		Public Shared DecompilePrefixFileNamesWithModelNameIsChecked = False
		Public Shared DecompileStricterFormatIsChecked = False
		Public Shared DecompileLogFileIsChecked = False
		Public Shared DecompileDebugInfoFilesIsChecked = False

		Public Shared DecompileOverrideMdlVersion = SupportedMdlVersion.DoNotOverride
		Public Shared DecompileMode = InputOptions.File
		Public Shared DecompilerIsRunning = False
	End Class

End Module

