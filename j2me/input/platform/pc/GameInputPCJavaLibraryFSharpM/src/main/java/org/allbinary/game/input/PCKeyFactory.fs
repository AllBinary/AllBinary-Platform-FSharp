namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
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
type PCKeyFactory =
    [<DefaultValue(false)>] val mutable keyEventWrapper : ABKeyEventWrapper
    [<DefaultValue(false)>] val mutable UNKNOWN : PCGameKey
    [<DefaultValue(false)>] val mutable ENTER : PCGameKey
    [<DefaultValue(false)>] val mutable _A : PCGameKey
    [<DefaultValue(false)>] val mutable _B : PCGameKey
    [<DefaultValue(false)>] val mutable _C : PCGameKey
    [<DefaultValue(false)>] val mutable _D : PCGameKey
    [<DefaultValue(false)>] val mutable _E : PCGameKey
    [<DefaultValue(false)>] val mutable _F : PCGameKey
    [<DefaultValue(false)>] val mutable _G : PCGameKey
    [<DefaultValue(false)>] val mutable _H : PCGameKey
    [<DefaultValue(false)>] val mutable _I : PCGameKey
    [<DefaultValue(false)>] val mutable _J : PCGameKey
    [<DefaultValue(false)>] val mutable _K : PCGameKey
    [<DefaultValue(false)>] val mutable _L : PCGameKey
    [<DefaultValue(false)>] val mutable _M : PCGameKey
    [<DefaultValue(false)>] val mutable _N : PCGameKey
    [<DefaultValue(false)>] val mutable _O : PCGameKey
    [<DefaultValue(false)>] val mutable _P : PCGameKey
    [<DefaultValue(false)>] val mutable _Q : PCGameKey
    [<DefaultValue(false)>] val mutable _R : PCGameKey
    [<DefaultValue(false)>] val mutable _S : PCGameKey
    [<DefaultValue(false)>] val mutable _T : PCGameKey
    [<DefaultValue(false)>] val mutable _U : PCGameKey
    [<DefaultValue(false)>] val mutable _V : PCGameKey
    [<DefaultValue(false)>] val mutable _W : PCGameKey
    [<DefaultValue(false)>] val mutable _X : PCGameKey
    [<DefaultValue(false)>] val mutable _Y : PCGameKey
    [<DefaultValue(false)>] val mutable _Z : PCGameKey
    [<DefaultValue(false)>] val mutable a : PCGameKey
    [<DefaultValue(false)>] val mutable b : PCGameKey
    [<DefaultValue(false)>] val mutable c : PCGameKey
    [<DefaultValue(false)>] val mutable d : PCGameKey
    [<DefaultValue(false)>] val mutable e : PCGameKey
    [<DefaultValue(false)>] val mutable f : PCGameKey
    [<DefaultValue(false)>] val mutable g : PCGameKey
    [<DefaultValue(false)>] val mutable h : PCGameKey
    [<DefaultValue(false)>] val mutable i : PCGameKey
    [<DefaultValue(false)>] val mutable j : PCGameKey
    [<DefaultValue(false)>] val mutable k : PCGameKey
    [<DefaultValue(false)>] val mutable l : PCGameKey
    [<DefaultValue(false)>] val mutable m : PCGameKey
    [<DefaultValue(false)>] val mutable n : PCGameKey
    [<DefaultValue(false)>] val mutable o : PCGameKey
    [<DefaultValue(false)>] val mutable p : PCGameKey
    [<DefaultValue(false)>] val mutable q : PCGameKey
    [<DefaultValue(false)>] val mutable r : PCGameKey
    [<DefaultValue(false)>] val mutable s : PCGameKey
    [<DefaultValue(false)>] val mutable t : PCGameKey
    [<DefaultValue(false)>] val mutable u : PCGameKey
    [<DefaultValue(false)>] val mutable v : PCGameKey
    [<DefaultValue(false)>] val mutable w : PCGameKey
    [<DefaultValue(false)>] val mutable x : PCGameKey
    [<DefaultValue(false)>] val mutable y : PCGameKey
    [<DefaultValue(false)>] val mutable z : PCGameKey
    [<DefaultValue(false)>] val mutable ZERO : PCGameKey
    [<DefaultValue(false)>] val mutable ONE : PCGameKey
    [<DefaultValue(false)>] val mutable TWO : PCGameKey
    [<DefaultValue(false)>] val mutable THREE : PCGameKey
    [<DefaultValue(false)>] val mutable FOUR : PCGameKey
    [<DefaultValue(false)>] val mutable FIVE : PCGameKey
    [<DefaultValue(false)>] val mutable SIX : PCGameKey
    [<DefaultValue(false)>] val mutable SEVEN : PCGameKey
    [<DefaultValue(false)>] val mutable EIGHT : PCGameKey
    [<DefaultValue(false)>] val mutable NINE : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_UP : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_DOWN : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_LEFT : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_RIGHT : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_UP2 : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_DOWN2 : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_LEFT2 : PCGameKey
    [<DefaultValue(false)>] val mutable DPAD_RIGHT2 : PCGameKey
    [<DefaultValue(false)>] val mutable COMMA : PCGameKey
    [<DefaultValue(false)>] val mutable SPACE : PCGameKey
    [<DefaultValue(false)>] val mutable DEL : PCGameKey
    [<DefaultValue(false)>] val mutable STAR : PCGameKey
    [<DefaultValue(false)>] val mutable QUESTION : PCGameKey
    [<DefaultValue(false)>] val mutable PERIOD : PCGameKey
    [<DefaultValue(false)>] val mutable ESCAPE : PCGameKey
    [<DefaultValue(false)>] val mutable BACK_SPACE : PCGameKey
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : PCKeyFactory
    static member SINGLETON with get() : PCKeyFactory = (PCKeyFactory.jclinit(); PCKeyFactory.jcell_SINGLETON) and set (jvalue: PCKeyFactory) = (PCKeyFactory.jclinit(); PCKeyFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PCKeyFactory.jclinitDone then
            PCKeyFactory.jclinitDone <- true
            PCKeyFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PCKeyFactory.jcell_SINGLETON <- (new PCKeyFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_PCKeyFactory()
    member this.jfields_PCKeyFactory() : unit =
        this.keyEventWrapper <- ABKeyEventWrapper.getInstance()
        this.UNKNOWN <- (new PCGameKey(this.keyEventWrapper.VK_UNDEFINED, "UNKNOWN"))
        this.ENTER <- (new PCGameKey(5, "Enter"))
        this._A <- (new PCGameKey(this.keyEventWrapper.VK_A, "A"))
        this._B <- (new PCGameKey(this.keyEventWrapper.VK_B, "B"))
        this._C <- (new PCGameKey(this.keyEventWrapper.VK_C, "C"))
        this._D <- (new PCGameKey(this.keyEventWrapper.VK_D, "D"))
        this._E <- (new PCGameKey(this.keyEventWrapper.VK_E, "E"))
        this._F <- (new PCGameKey(this.keyEventWrapper.VK_F, "F"))
        this._G <- (new PCGameKey(this.keyEventWrapper.VK_G, "G"))
        this._H <- (new PCGameKey(this.keyEventWrapper.VK_H, "H"))
        this._I <- (new PCGameKey(this.keyEventWrapper.VK_I, "I"))
        this._J <- (new PCGameKey(this.keyEventWrapper.VK_J, "J"))
        this._K <- (new PCGameKey(this.keyEventWrapper.VK_K, "K"))
        this._L <- (new PCGameKey(this.keyEventWrapper.VK_L, "L"))
        this._M <- (new PCGameKey(this.keyEventWrapper.VK_M, "M"))
        this._N <- (new PCGameKey(this.keyEventWrapper.VK_N, "N"))
        this._O <- (new PCGameKey(this.keyEventWrapper.VK_O, "O"))
        this._P <- (new PCGameKey(this.keyEventWrapper.VK_P, "P"))
        this._Q <- (new PCGameKey(this.keyEventWrapper.VK_Q, "Q"))
        this._R <- (new PCGameKey(this.keyEventWrapper.VK_R, "R"))
        this._S <- (new PCGameKey(this.keyEventWrapper.VK_S, "S"))
        this._T <- (new PCGameKey(this.keyEventWrapper.VK_T, "T"))
        this._U <- (new PCGameKey(this.keyEventWrapper.VK_U, "U"))
        this._V <- (new PCGameKey(this.keyEventWrapper.VK_V, "V"))
        this._W <- (new PCGameKey(this.keyEventWrapper.VK_W, "W"))
        this._X <- (new PCGameKey(this.keyEventWrapper.VK_X, "X"))
        this._Y <- (new PCGameKey(this.keyEventWrapper.VK_Y, "Y"))
        this._Z <- (new PCGameKey(this.keyEventWrapper.VK_Z, "Z"))
        this.a <- (new PCGameKey(97, "a"))
        this.b <- (new PCGameKey(98, "b"))
        this.c <- (new PCGameKey(99, "c"))
        this.d <- (new PCGameKey(100, "d"))
        this.e <- (new PCGameKey(101, "e"))
        this.f <- (new PCGameKey(102, "f"))
        this.g <- (new PCGameKey(103, "g"))
        this.h <- (new PCGameKey(104, "h"))
        this.i <- (new PCGameKey(105, "i"))
        this.j <- (new PCGameKey(106, "j"))
        this.k <- (new PCGameKey(107, "k"))
        this.l <- (new PCGameKey(108, "l"))
        this.m <- (new PCGameKey(109, "m"))
        this.n <- (new PCGameKey(110, "n"))
        this.o <- (new PCGameKey(111, "o"))
        this.p <- (new PCGameKey(112, "p"))
        this.q <- (new PCGameKey(113, "q"))
        this.r <- (new PCGameKey(114, "r"))
        this.s <- (new PCGameKey(115, "s"))
        this.t <- (new PCGameKey(116, "t"))
        this.u <- (new PCGameKey(117, "u"))
        this.v <- (new PCGameKey(118, "v"))
        this.w <- (new PCGameKey(119, "w"))
        this.x <- (new PCGameKey(120, PositionStrings.getInstance().X))
        this.y <- (new PCGameKey(121, PositionStrings.getInstance().Y))
        this.z <- (new PCGameKey(122, "z"))
        this.ZERO <- (new PCGameKey(this.keyEventWrapper.VK_0, CommonPhoneStrings.getInstance().ZERO))
        this.ONE <- (new PCGameKey(this.keyEventWrapper.VK_1, CommonPhoneStrings.getInstance().ONE))
        this.TWO <- (new PCGameKey(this.keyEventWrapper.VK_2, CommonPhoneStrings.getInstance().TWO))
        this.THREE <- (new PCGameKey(this.keyEventWrapper.VK_3, CommonPhoneStrings.getInstance().THREE))
        this.FOUR <- (new PCGameKey(this.keyEventWrapper.VK_4, CommonPhoneStrings.getInstance().FOUR))
        this.FIVE <- (new PCGameKey(this.keyEventWrapper.VK_5, CommonPhoneStrings.getInstance().FIVE))
        this.SIX <- (new PCGameKey(this.keyEventWrapper.VK_6, CommonPhoneStrings.getInstance().SIX))
        this.SEVEN <- (new PCGameKey(this.keyEventWrapper.VK_7, CommonPhoneStrings.getInstance().SEVEN))
        this.EIGHT <- (new PCGameKey(this.keyEventWrapper.VK_8, CommonPhoneStrings.getInstance().EIGHT))
        this.NINE <- (new PCGameKey(this.keyEventWrapper.VK_9, CommonPhoneStrings.getInstance().NINE))
        this.DPAD_UP <- (new PCGameKey(this.keyEventWrapper.VK_UP, CommonPhoneStrings.getInstance().UP))
        this.DPAD_DOWN <- (new PCGameKey(this.keyEventWrapper.VK_DOWN, CommonPhoneStrings.getInstance().DOWN))
        this.DPAD_LEFT <- (new PCGameKey(this.keyEventWrapper.VK_LEFT, CommonPhoneStrings.getInstance().LEFT))
        this.DPAD_RIGHT <- (new PCGameKey(this.keyEventWrapper.VK_RIGHT, CommonPhoneStrings.getInstance().RIGHT))
        this.DPAD_UP2 <- this.DPAD_UP
        this.DPAD_DOWN2 <- this.DPAD_DOWN
        this.DPAD_LEFT2 <- this.DPAD_LEFT
        this.DPAD_RIGHT2 <- this.DPAD_RIGHT
        this.COMMA <- (new PCGameKey(this.keyEventWrapper.VK_COMMA, "COMMA"))
        this.SPACE <- (new PCGameKey(this.keyEventWrapper.VK_SPACE, "SPACE"))
        this.DEL <- (new PCGameKey(this.keyEventWrapper.VK_DELETE, "DEL"))
        this.STAR <- (new PCGameKey(42, CommonPhoneStrings.getInstance().STAR))
        this.QUESTION <- (new PCGameKey(47, "?"))
        this.PERIOD <- (new PCGameKey(this.keyEventWrapper.VK_PERIOD, CommonSeps.getInstance().PERIOD))
        this.ESCAPE <- (new PCGameKey(this.keyEventWrapper.VK_ESCAPE, "Esc"))
        this.BACK_SPACE <- (new PCGameKey(this.keyEventWrapper.VK_BACK_SPACE, "Backspace"))
        ()
    
    static member getInstance() : PCKeyFactory =
        PCKeyFactory.SINGLETON
    
    abstract isSubmission : input: Input -> bool
    default this.isSubmission(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, this.ENTER)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isDelete : input: Input -> bool
    default this.isDelete(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, this.DEL)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isBackSpace : input: Input -> bool
    default this.isBackSpace(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, this.BACK_SPACE)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isUp : input: Input -> bool
    default this.isUp(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if ((JR.same(input, this.DPAD_UP))) || ((JR.same(input, this.DPAD_UP2))) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isDown : input: Input -> bool
    default this.isDown(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if ((JR.same(input, this.DPAD_DOWN))) || ((JR.same(input, this.DPAD_DOWN2))) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isLeft : input: Input -> bool
    default this.isLeft(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if ((JR.same(input, this.DPAD_LEFT))) || ((JR.same(input, this.DPAD_LEFT2))) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isRight : input: Input -> bool
    default this.isRight(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if ((JR.same(input, this.DPAD_RIGHT))) || ((JR.same(input, this.DPAD_RIGHT2))) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isEnter : input: Input -> bool
    default this.isEnter(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, this.ENTER)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret


