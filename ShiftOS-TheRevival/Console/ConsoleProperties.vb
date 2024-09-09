Module ConsoleProperties

    Public Property C_TextSize As Integer
    Public Property C_TextStyle As FontFamily
    Public Property C_TextStyleSelected As FontFamily
    Public Property C_Header_Height As Integer                      ' The value is then multiplied by the font size (Max 3)
    Public Property C_Footer_Height As Integer                      ' The value is then multiplied by the font size (Max 2)
    Public Property C_CurrentApp As String                          ' Get to know what app is using the Console so that Console doesn't always have to run Terminal
    Public Property C_IsSecureTypeEnabled As Boolean                ' To know if the SecureType sub is enabled or not

End Module
