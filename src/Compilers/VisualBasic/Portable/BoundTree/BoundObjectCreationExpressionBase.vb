﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis.Text
Imports Microsoft.CodeAnalysis.VisualBasic.Symbols
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Microsoft.CodeAnalysis.VisualBasic

    Partial Class BoundObjectCreationExpressionBase

#If DEBUG Then
        Private Sub Validate()
            Debug.Assert(InitializerOpt Is Nothing OrElse InitializerOpt.Type = Type)
        End Sub
#End If

    End Class

End Namespace
