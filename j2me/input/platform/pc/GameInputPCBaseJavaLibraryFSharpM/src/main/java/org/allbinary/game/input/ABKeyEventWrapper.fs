namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
 *  
 * By agreeing to this license you and any business entity you represent are 
 * legally bound to the AllBinary Open License Version 1 legal agreement. 
 *  
 * You may obtain the AllBinary Open License Version 1 legal agreement from 
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository. 
 *  
 * Created By: Travis Berthelot 
 *   
 *)

[<AllowNullLiteral>]
type ABKeyEventWrapper =
    [<DefaultValue(false)>] val mutable VK_ENTER : int
    [<DefaultValue(false)>] val mutable VK_BACK_SPACE : int
    [<DefaultValue(false)>] val mutable VK_TAB : int
    [<DefaultValue(false)>] val mutable VK_CANCEL : int
    [<DefaultValue(false)>] val mutable VK_CLEAR : int
    [<DefaultValue(false)>] val mutable VK_SHIFT : int
    [<DefaultValue(false)>] val mutable VK_CONTROL : int
    [<DefaultValue(false)>] val mutable VK_ALT : int
    [<DefaultValue(false)>] val mutable VK_PAUSE : int
    [<DefaultValue(false)>] val mutable VK_CAPS_LOCK : int
    [<DefaultValue(false)>] val mutable VK_ESCAPE : int
    [<DefaultValue(false)>] val mutable VK_SPACE : int
    [<DefaultValue(false)>] val mutable VK_PAGE_UP : int
    [<DefaultValue(false)>] val mutable VK_PAGE_DOWN : int
    [<DefaultValue(false)>] val mutable VK_END : int
    [<DefaultValue(false)>] val mutable VK_HOME : int
    [<DefaultValue(false)>] val mutable VK_LEFT : int
    [<DefaultValue(false)>] val mutable VK_UP : int
    [<DefaultValue(false)>] val mutable VK_RIGHT : int
    [<DefaultValue(false)>] val mutable VK_DOWN : int
    [<DefaultValue(false)>] val mutable VK_COMMA : int
    [<DefaultValue(false)>] val mutable VK_MINUS : int
    [<DefaultValue(false)>] val mutable VK_PERIOD : int
    [<DefaultValue(false)>] val mutable VK_SLASH : int
    [<DefaultValue(false)>] val mutable VK_0 : int
    [<DefaultValue(false)>] val mutable VK_1 : int
    [<DefaultValue(false)>] val mutable VK_2 : int
    [<DefaultValue(false)>] val mutable VK_3 : int
    [<DefaultValue(false)>] val mutable VK_4 : int
    [<DefaultValue(false)>] val mutable VK_5 : int
    [<DefaultValue(false)>] val mutable VK_6 : int
    [<DefaultValue(false)>] val mutable VK_7 : int
    [<DefaultValue(false)>] val mutable VK_8 : int
    [<DefaultValue(false)>] val mutable VK_9 : int
    [<DefaultValue(false)>] val mutable VK_SEMICOLON : int
    [<DefaultValue(false)>] val mutable VK_EQUALS : int
    [<DefaultValue(false)>] val mutable VK_A : int
    [<DefaultValue(false)>] val mutable VK_B : int
    [<DefaultValue(false)>] val mutable VK_C : int
    [<DefaultValue(false)>] val mutable VK_D : int
    [<DefaultValue(false)>] val mutable VK_E : int
    [<DefaultValue(false)>] val mutable VK_F : int
    [<DefaultValue(false)>] val mutable VK_G : int
    [<DefaultValue(false)>] val mutable VK_H : int
    [<DefaultValue(false)>] val mutable VK_I : int
    [<DefaultValue(false)>] val mutable VK_J : int
    [<DefaultValue(false)>] val mutable VK_K : int
    [<DefaultValue(false)>] val mutable VK_L : int
    [<DefaultValue(false)>] val mutable VK_M : int
    [<DefaultValue(false)>] val mutable VK_N : int
    [<DefaultValue(false)>] val mutable VK_O : int
    [<DefaultValue(false)>] val mutable VK_P : int
    [<DefaultValue(false)>] val mutable VK_Q : int
    [<DefaultValue(false)>] val mutable VK_R : int
    [<DefaultValue(false)>] val mutable VK_S : int
    [<DefaultValue(false)>] val mutable VK_T : int
    [<DefaultValue(false)>] val mutable VK_U : int
    [<DefaultValue(false)>] val mutable VK_V : int
    [<DefaultValue(false)>] val mutable VK_W : int
    [<DefaultValue(false)>] val mutable VK_X : int
    [<DefaultValue(false)>] val mutable VK_Y : int
    [<DefaultValue(false)>] val mutable VK_Z : int
    [<DefaultValue(false)>] val mutable VK_OPEN_BRACKET : int
    [<DefaultValue(false)>] val mutable VK_BACK_SLASH : int
    [<DefaultValue(false)>] val mutable VK_CLOSE_BRACKET : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD0 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD1 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD2 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD3 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD4 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD5 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD6 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD7 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD8 : int
    [<DefaultValue(false)>] val mutable VK_NUMPAD9 : int
    [<DefaultValue(false)>] val mutable VK_MULTIPLY : int
    [<DefaultValue(false)>] val mutable VK_ADD : int
    [<DefaultValue(false)>] val mutable VK_SEPARATER : int
    [<DefaultValue(false)>] val mutable VK_SEPARATOR : int
    [<DefaultValue(false)>] val mutable VK_SUBTRACT : int
    [<DefaultValue(false)>] val mutable VK_DECIMAL : int
    [<DefaultValue(false)>] val mutable VK_DIVIDE : int
    [<DefaultValue(false)>] val mutable VK_DELETE : int
    [<DefaultValue(false)>] val mutable VK_NUM_LOCK : int
    [<DefaultValue(false)>] val mutable VK_SCROLL_LOCK : int
    [<DefaultValue(false)>] val mutable VK_F1 : int
    [<DefaultValue(false)>] val mutable VK_F2 : int
    [<DefaultValue(false)>] val mutable VK_F3 : int
    [<DefaultValue(false)>] val mutable VK_F4 : int
    [<DefaultValue(false)>] val mutable VK_F5 : int
    [<DefaultValue(false)>] val mutable VK_F6 : int
    [<DefaultValue(false)>] val mutable VK_F7 : int
    [<DefaultValue(false)>] val mutable VK_F8 : int
    [<DefaultValue(false)>] val mutable VK_F9 : int
    [<DefaultValue(false)>] val mutable VK_F10 : int
    [<DefaultValue(false)>] val mutable VK_F11 : int
    [<DefaultValue(false)>] val mutable VK_F12 : int
    [<DefaultValue(false)>] val mutable VK_F13 : int
    [<DefaultValue(false)>] val mutable VK_F14 : int
    [<DefaultValue(false)>] val mutable VK_F15 : int
    [<DefaultValue(false)>] val mutable VK_F16 : int
    [<DefaultValue(false)>] val mutable VK_F17 : int
    [<DefaultValue(false)>] val mutable VK_F18 : int
    [<DefaultValue(false)>] val mutable VK_F19 : int
    [<DefaultValue(false)>] val mutable VK_F20 : int
    [<DefaultValue(false)>] val mutable VK_F21 : int
    [<DefaultValue(false)>] val mutable VK_F22 : int
    [<DefaultValue(false)>] val mutable VK_F23 : int
    [<DefaultValue(false)>] val mutable VK_F24 : int
    [<DefaultValue(false)>] val mutable VK_PRINTSCREEN : int
    [<DefaultValue(false)>] val mutable VK_INSERT : int
    [<DefaultValue(false)>] val mutable VK_HELP : int
    [<DefaultValue(false)>] val mutable VK_META : int
    [<DefaultValue(false)>] val mutable VK_BACK_QUOTE : int
    [<DefaultValue(false)>] val mutable VK_QUOTE : int
    [<DefaultValue(false)>] val mutable VK_KP_UP : int
    [<DefaultValue(false)>] val mutable VK_KP_DOWN : int
    [<DefaultValue(false)>] val mutable VK_KP_LEFT : int
    [<DefaultValue(false)>] val mutable VK_KP_RIGHT : int
    [<DefaultValue(false)>] val mutable VK_DEAD_GRAVE : int
    [<DefaultValue(false)>] val mutable VK_DEAD_ACUTE : int
    [<DefaultValue(false)>] val mutable VK_DEAD_CIRCUMFLEX : int
    [<DefaultValue(false)>] val mutable VK_DEAD_TILDE : int
    [<DefaultValue(false)>] val mutable VK_DEAD_MACRON : int
    [<DefaultValue(false)>] val mutable VK_DEAD_BREVE : int
    [<DefaultValue(false)>] val mutable VK_DEAD_ABOVEDOT : int
    [<DefaultValue(false)>] val mutable VK_DEAD_DIAERESIS : int
    [<DefaultValue(false)>] val mutable VK_DEAD_ABOVERING : int
    [<DefaultValue(false)>] val mutable VK_DEAD_DOUBLEACUTE : int
    [<DefaultValue(false)>] val mutable VK_DEAD_CARON : int
    [<DefaultValue(false)>] val mutable VK_DEAD_CEDILLA : int
    [<DefaultValue(false)>] val mutable VK_DEAD_OGONEK : int
    [<DefaultValue(false)>] val mutable VK_DEAD_IOTA : int
    [<DefaultValue(false)>] val mutable VK_DEAD_VOICED_SOUND : int
    [<DefaultValue(false)>] val mutable VK_DEAD_SEMIVOICED_SOUND : int
    [<DefaultValue(false)>] val mutable VK_AMPERSAND : int
    [<DefaultValue(false)>] val mutable VK_ASTERISK : int
    [<DefaultValue(false)>] val mutable VK_QUOTEDBL : int
    [<DefaultValue(false)>] val mutable VK_LESS : int
    [<DefaultValue(false)>] val mutable VK_GREATER : int
    [<DefaultValue(false)>] val mutable VK_BRACELEFT : int
    [<DefaultValue(false)>] val mutable VK_BRACERIGHT : int
    [<DefaultValue(false)>] val mutable VK_AT : int
    [<DefaultValue(false)>] val mutable VK_COLON : int
    [<DefaultValue(false)>] val mutable VK_CIRCUMFLEX : int
    [<DefaultValue(false)>] val mutable VK_DOLLAR : int
    [<DefaultValue(false)>] val mutable VK_EURO_SIGN : int
    [<DefaultValue(false)>] val mutable VK_EXCLAMATION_MARK : int
    [<DefaultValue(false)>] val mutable VK_INVERTED_EXCLAMATION_MARK : int
    [<DefaultValue(false)>] val mutable VK_LEFT_PARENTHESIS : int
    [<DefaultValue(false)>] val mutable VK_NUMBER_SIGN : int
    [<DefaultValue(false)>] val mutable VK_PLUS : int
    [<DefaultValue(false)>] val mutable VK_RIGHT_PARENTHESIS : int
    [<DefaultValue(false)>] val mutable VK_UNDERSCORE : int
    [<DefaultValue(false)>] val mutable VK_WINDOWS : int
    [<DefaultValue(false)>] val mutable VK_CONTEXT_MENU : int
    [<DefaultValue(false)>] val mutable VK_FINAL : int
    [<DefaultValue(false)>] val mutable VK_CONVERT : int
    [<DefaultValue(false)>] val mutable VK_NONCONVERT : int
    [<DefaultValue(false)>] val mutable VK_ACCEPT : int
    [<DefaultValue(false)>] val mutable VK_MODECHANGE : int
    [<DefaultValue(false)>] val mutable VK_KANA : int
    [<DefaultValue(false)>] val mutable VK_KANJI : int
    [<DefaultValue(false)>] val mutable VK_ALPHANUMERIC : int
    [<DefaultValue(false)>] val mutable VK_KATAKANA : int
    [<DefaultValue(false)>] val mutable VK_HIRAGANA : int
    [<DefaultValue(false)>] val mutable VK_FULL_WIDTH : int
    [<DefaultValue(false)>] val mutable VK_HALF_WIDTH : int
    [<DefaultValue(false)>] val mutable VK_ROMAN_CHARACTERS : int
    [<DefaultValue(false)>] val mutable VK_ALL_CANDIDATES : int
    [<DefaultValue(false)>] val mutable VK_PREVIOUS_CANDIDATE : int
    [<DefaultValue(false)>] val mutable VK_CODE_INPUT : int
    [<DefaultValue(false)>] val mutable VK_JAPANESE_KATAKANA : int
    [<DefaultValue(false)>] val mutable VK_JAPANESE_HIRAGANA : int
    [<DefaultValue(false)>] val mutable VK_JAPANESE_ROMAN : int
    [<DefaultValue(false)>] val mutable VK_KANA_LOCK : int
    [<DefaultValue(false)>] val mutable VK_INPUT_METHOD_ON_OFF : int
    [<DefaultValue(false)>] val mutable VK_CUT : int
    [<DefaultValue(false)>] val mutable VK_COPY : int
    [<DefaultValue(false)>] val mutable VK_PASTE : int
    [<DefaultValue(false)>] val mutable VK_UNDO : int
    [<DefaultValue(false)>] val mutable VK_AGAIN : int
    [<DefaultValue(false)>] val mutable VK_FIND : int
    [<DefaultValue(false)>] val mutable VK_PROPS : int
    [<DefaultValue(false)>] val mutable VK_STOP : int
    [<DefaultValue(false)>] val mutable VK_COMPOSE : int
    [<DefaultValue(false)>] val mutable VK_ALT_GRAPH : int
    [<DefaultValue(false)>] val mutable VK_BEGIN : int
    [<DefaultValue(false)>] val mutable VK_UNDEFINED : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : ABKeyEventWrapper
    static member instance with get() : ABKeyEventWrapper = (ABKeyEventWrapper.jclinit(); ABKeyEventWrapper.jcell_instance) and set (jvalue: ABKeyEventWrapper) = (ABKeyEventWrapper.jclinit(); ABKeyEventWrapper.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABKeyEventWrapper.jclinitDone then
            ABKeyEventWrapper.jclinitDone <- true
            ABKeyEventWrapper.jclinitBody()
    static member private jclinitBody() : unit =
        ABKeyEventWrapper.jcell_instance <- (new ABKeyEventWrapper())
        ()
    new () as this =
        {  }
        then
            this.jfields_ABKeyEventWrapper()
    member this.jfields_ABKeyEventWrapper() : unit =
        this.VK_ENTER <- KeyEvent.VK_ENTER
        this.VK_BACK_SPACE <- KeyEvent.VK_BACK_SPACE
        this.VK_TAB <- KeyEvent.VK_TAB
        this.VK_CANCEL <- KeyEvent.VK_CANCEL
        this.VK_CLEAR <- KeyEvent.VK_CLEAR
        this.VK_SHIFT <- KeyEvent.VK_SHIFT
        this.VK_CONTROL <- KeyEvent.VK_CONTROL
        this.VK_ALT <- KeyEvent.VK_ALT
        this.VK_PAUSE <- KeyEvent.VK_PAUSE
        this.VK_CAPS_LOCK <- KeyEvent.VK_CAPS_LOCK
        this.VK_ESCAPE <- KeyEvent.VK_ESCAPE
        this.VK_SPACE <- KeyEvent.VK_SPACE
        this.VK_PAGE_UP <- KeyEvent.VK_PAGE_UP
        this.VK_PAGE_DOWN <- KeyEvent.VK_PAGE_DOWN
        this.VK_END <- KeyEvent.VK_END
        this.VK_HOME <- KeyEvent.VK_HOME
        this.VK_LEFT <- KeyEvent.VK_LEFT
        this.VK_UP <- KeyEvent.VK_UP
        this.VK_RIGHT <- KeyEvent.VK_RIGHT
        this.VK_DOWN <- KeyEvent.VK_DOWN
        this.VK_COMMA <- KeyEvent.VK_COMMA
        this.VK_MINUS <- KeyEvent.VK_MINUS
        this.VK_PERIOD <- KeyEvent.VK_PERIOD
        this.VK_SLASH <- KeyEvent.VK_SLASH
        this.VK_0 <- KeyEvent.VK_0
        this.VK_1 <- KeyEvent.VK_1
        this.VK_2 <- KeyEvent.VK_2
        this.VK_3 <- KeyEvent.VK_3
        this.VK_4 <- KeyEvent.VK_4
        this.VK_5 <- KeyEvent.VK_5
        this.VK_6 <- KeyEvent.VK_6
        this.VK_7 <- KeyEvent.VK_7
        this.VK_8 <- KeyEvent.VK_8
        this.VK_9 <- KeyEvent.VK_9
        this.VK_SEMICOLON <- KeyEvent.VK_SEMICOLON
        this.VK_EQUALS <- KeyEvent.VK_EQUALS
        this.VK_A <- KeyEvent.VK_A
        this.VK_B <- KeyEvent.VK_B
        this.VK_C <- KeyEvent.VK_C
        this.VK_D <- KeyEvent.VK_D
        this.VK_E <- KeyEvent.VK_E
        this.VK_F <- KeyEvent.VK_F
        this.VK_G <- KeyEvent.VK_G
        this.VK_H <- KeyEvent.VK_H
        this.VK_I <- KeyEvent.VK_I
        this.VK_J <- KeyEvent.VK_J
        this.VK_K <- KeyEvent.VK_K
        this.VK_L <- KeyEvent.VK_L
        this.VK_M <- KeyEvent.VK_M
        this.VK_N <- KeyEvent.VK_N
        this.VK_O <- KeyEvent.VK_O
        this.VK_P <- KeyEvent.VK_P
        this.VK_Q <- KeyEvent.VK_Q
        this.VK_R <- KeyEvent.VK_R
        this.VK_S <- KeyEvent.VK_S
        this.VK_T <- KeyEvent.VK_T
        this.VK_U <- KeyEvent.VK_U
        this.VK_V <- KeyEvent.VK_V
        this.VK_W <- KeyEvent.VK_W
        this.VK_X <- KeyEvent.VK_X
        this.VK_Y <- KeyEvent.VK_Y
        this.VK_Z <- KeyEvent.VK_Z
        this.VK_OPEN_BRACKET <- KeyEvent.VK_OPEN_BRACKET
        this.VK_BACK_SLASH <- KeyEvent.VK_BACK_SLASH
        this.VK_CLOSE_BRACKET <- KeyEvent.VK_CLOSE_BRACKET
        this.VK_NUMPAD0 <- KeyEvent.VK_NUMPAD0
        this.VK_NUMPAD1 <- KeyEvent.VK_NUMPAD1
        this.VK_NUMPAD2 <- KeyEvent.VK_NUMPAD2
        this.VK_NUMPAD3 <- KeyEvent.VK_NUMPAD3
        this.VK_NUMPAD4 <- KeyEvent.VK_NUMPAD4
        this.VK_NUMPAD5 <- KeyEvent.VK_NUMPAD5
        this.VK_NUMPAD6 <- KeyEvent.VK_NUMPAD6
        this.VK_NUMPAD7 <- KeyEvent.VK_NUMPAD7
        this.VK_NUMPAD8 <- KeyEvent.VK_NUMPAD8
        this.VK_NUMPAD9 <- KeyEvent.VK_NUMPAD9
        this.VK_MULTIPLY <- KeyEvent.VK_MULTIPLY
        this.VK_ADD <- KeyEvent.VK_ADD
        this.VK_SEPARATER <- KeyEvent.VK_SEPARATER
        this.VK_SEPARATOR <- KeyEvent.VK_SEPARATOR
        this.VK_SUBTRACT <- KeyEvent.VK_SUBTRACT
        this.VK_DECIMAL <- KeyEvent.VK_DECIMAL
        this.VK_DIVIDE <- KeyEvent.VK_DIVIDE
        this.VK_DELETE <- KeyEvent.VK_DELETE
        this.VK_NUM_LOCK <- KeyEvent.VK_NUM_LOCK
        this.VK_SCROLL_LOCK <- KeyEvent.VK_SCROLL_LOCK
        this.VK_F1 <- KeyEvent.VK_F1
        this.VK_F2 <- KeyEvent.VK_F2
        this.VK_F3 <- KeyEvent.VK_F3
        this.VK_F4 <- KeyEvent.VK_F4
        this.VK_F5 <- KeyEvent.VK_F5
        this.VK_F6 <- KeyEvent.VK_F6
        this.VK_F7 <- KeyEvent.VK_F7
        this.VK_F8 <- KeyEvent.VK_F8
        this.VK_F9 <- KeyEvent.VK_F9
        this.VK_F10 <- KeyEvent.VK_F10
        this.VK_F11 <- KeyEvent.VK_F11
        this.VK_F12 <- KeyEvent.VK_F12
        this.VK_F13 <- KeyEvent.VK_F13
        this.VK_F14 <- KeyEvent.VK_F14
        this.VK_F15 <- KeyEvent.VK_F15
        this.VK_F16 <- KeyEvent.VK_F16
        this.VK_F17 <- KeyEvent.VK_F17
        this.VK_F18 <- KeyEvent.VK_F18
        this.VK_F19 <- KeyEvent.VK_F19
        this.VK_F20 <- KeyEvent.VK_F20
        this.VK_F21 <- KeyEvent.VK_F21
        this.VK_F22 <- KeyEvent.VK_F22
        this.VK_F23 <- KeyEvent.VK_F23
        this.VK_F24 <- KeyEvent.VK_F24
        this.VK_PRINTSCREEN <- KeyEvent.VK_PRINTSCREEN
        this.VK_INSERT <- KeyEvent.VK_INSERT
        this.VK_HELP <- KeyEvent.VK_HELP
        this.VK_META <- KeyEvent.VK_META
        this.VK_BACK_QUOTE <- KeyEvent.VK_BACK_QUOTE
        this.VK_QUOTE <- KeyEvent.VK_QUOTE
        this.VK_KP_UP <- KeyEvent.VK_KP_UP
        this.VK_KP_DOWN <- KeyEvent.VK_KP_DOWN
        this.VK_KP_LEFT <- KeyEvent.VK_KP_LEFT
        this.VK_KP_RIGHT <- KeyEvent.VK_KP_RIGHT
        this.VK_DEAD_GRAVE <- KeyEvent.VK_DEAD_GRAVE
        this.VK_DEAD_ACUTE <- KeyEvent.VK_DEAD_ACUTE
        this.VK_DEAD_CIRCUMFLEX <- KeyEvent.VK_DEAD_CIRCUMFLEX
        this.VK_DEAD_TILDE <- KeyEvent.VK_DEAD_TILDE
        this.VK_DEAD_MACRON <- KeyEvent.VK_DEAD_MACRON
        this.VK_DEAD_BREVE <- KeyEvent.VK_DEAD_BREVE
        this.VK_DEAD_ABOVEDOT <- KeyEvent.VK_DEAD_ABOVEDOT
        this.VK_DEAD_DIAERESIS <- KeyEvent.VK_DEAD_DIAERESIS
        this.VK_DEAD_ABOVERING <- KeyEvent.VK_DEAD_ABOVERING
        this.VK_DEAD_DOUBLEACUTE <- KeyEvent.VK_DEAD_DOUBLEACUTE
        this.VK_DEAD_CARON <- KeyEvent.VK_DEAD_CARON
        this.VK_DEAD_CEDILLA <- KeyEvent.VK_DEAD_CEDILLA
        this.VK_DEAD_OGONEK <- KeyEvent.VK_DEAD_OGONEK
        this.VK_DEAD_IOTA <- KeyEvent.VK_DEAD_IOTA
        this.VK_DEAD_VOICED_SOUND <- KeyEvent.VK_DEAD_VOICED_SOUND
        this.VK_DEAD_SEMIVOICED_SOUND <- KeyEvent.VK_DEAD_SEMIVOICED_SOUND
        this.VK_AMPERSAND <- KeyEvent.VK_AMPERSAND
        this.VK_ASTERISK <- KeyEvent.VK_ASTERISK
        this.VK_QUOTEDBL <- KeyEvent.VK_QUOTEDBL
        this.VK_LESS <- KeyEvent.VK_LESS
        this.VK_GREATER <- KeyEvent.VK_GREATER
        this.VK_BRACELEFT <- KeyEvent.VK_BRACELEFT
        this.VK_BRACERIGHT <- KeyEvent.VK_BRACERIGHT
        this.VK_AT <- KeyEvent.VK_AT
        this.VK_COLON <- KeyEvent.VK_COLON
        this.VK_CIRCUMFLEX <- KeyEvent.VK_CIRCUMFLEX
        this.VK_DOLLAR <- KeyEvent.VK_DOLLAR
        this.VK_EURO_SIGN <- KeyEvent.VK_EURO_SIGN
        this.VK_EXCLAMATION_MARK <- KeyEvent.VK_EXCLAMATION_MARK
        this.VK_INVERTED_EXCLAMATION_MARK <- KeyEvent.VK_INVERTED_EXCLAMATION_MARK
        this.VK_LEFT_PARENTHESIS <- KeyEvent.VK_LEFT_PARENTHESIS
        this.VK_NUMBER_SIGN <- KeyEvent.VK_NUMBER_SIGN
        this.VK_PLUS <- KeyEvent.VK_PLUS
        this.VK_RIGHT_PARENTHESIS <- KeyEvent.VK_RIGHT_PARENTHESIS
        this.VK_UNDERSCORE <- KeyEvent.VK_UNDERSCORE
        this.VK_WINDOWS <- KeyEvent.VK_WINDOWS
        this.VK_CONTEXT_MENU <- KeyEvent.VK_CONTEXT_MENU
        this.VK_FINAL <- KeyEvent.VK_FINAL
        this.VK_CONVERT <- KeyEvent.VK_CONVERT
        this.VK_NONCONVERT <- KeyEvent.VK_NONCONVERT
        this.VK_ACCEPT <- KeyEvent.VK_ACCEPT
        this.VK_MODECHANGE <- KeyEvent.VK_MODECHANGE
        this.VK_KANA <- KeyEvent.VK_KANA
        this.VK_KANJI <- KeyEvent.VK_KANJI
        this.VK_ALPHANUMERIC <- KeyEvent.VK_ALPHANUMERIC
        this.VK_KATAKANA <- KeyEvent.VK_KATAKANA
        this.VK_HIRAGANA <- KeyEvent.VK_HIRAGANA
        this.VK_FULL_WIDTH <- KeyEvent.VK_FULL_WIDTH
        this.VK_HALF_WIDTH <- KeyEvent.VK_HALF_WIDTH
        this.VK_ROMAN_CHARACTERS <- KeyEvent.VK_ROMAN_CHARACTERS
        this.VK_ALL_CANDIDATES <- KeyEvent.VK_ALL_CANDIDATES
        this.VK_PREVIOUS_CANDIDATE <- KeyEvent.VK_PREVIOUS_CANDIDATE
        this.VK_CODE_INPUT <- KeyEvent.VK_CODE_INPUT
        this.VK_JAPANESE_KATAKANA <- KeyEvent.VK_JAPANESE_KATAKANA
        this.VK_JAPANESE_HIRAGANA <- KeyEvent.VK_JAPANESE_HIRAGANA
        this.VK_JAPANESE_ROMAN <- KeyEvent.VK_JAPANESE_ROMAN
        this.VK_KANA_LOCK <- KeyEvent.VK_KANA_LOCK
        this.VK_INPUT_METHOD_ON_OFF <- KeyEvent.VK_INPUT_METHOD_ON_OFF
        this.VK_CUT <- KeyEvent.VK_CUT
        this.VK_COPY <- KeyEvent.VK_COPY
        this.VK_PASTE <- KeyEvent.VK_PASTE
        this.VK_UNDO <- KeyEvent.VK_UNDO
        this.VK_AGAIN <- KeyEvent.VK_AGAIN
        this.VK_FIND <- KeyEvent.VK_FIND
        this.VK_PROPS <- KeyEvent.VK_PROPS
        this.VK_STOP <- KeyEvent.VK_STOP
        this.VK_COMPOSE <- KeyEvent.VK_COMPOSE
        this.VK_ALT_GRAPH <- KeyEvent.VK_ALT_GRAPH
        this.VK_BEGIN <- KeyEvent.VK_BEGIN
        this.VK_UNDEFINED <- KeyEvent.VK_UNDEFINED
        ()
    
    static member getInstance() : ABKeyEventWrapper =
        ABKeyEventWrapper.instance


