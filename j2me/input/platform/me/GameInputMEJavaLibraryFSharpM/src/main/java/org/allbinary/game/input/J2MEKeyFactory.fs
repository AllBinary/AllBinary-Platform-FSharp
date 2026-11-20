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
type J2MEKeyFactory =
    [<DefaultValue(false)>] val mutable gameKeyFactory : GameKeyFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : J2MEKeyFactory
    static member instance with get() : J2MEKeyFactory = (J2MEKeyFactory.jclinit(); J2MEKeyFactory.jcell_instance) and set (jvalue: J2MEKeyFactory) = (J2MEKeyFactory.jclinit(); J2MEKeyFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not J2MEKeyFactory.jclinitDone then
            J2MEKeyFactory.jclinitDone <- true
            J2MEKeyFactory.jclinitBody()
    static member private jclinitBody() : unit =
        J2MEKeyFactory.jcell_instance <- (new J2MEKeyFactory())
        ()
    member this.jfields_J2MEKeyFactory() : unit =
        this.gameKeyFactory <- GameKeyFactory.getInstance()
        ()
    
    static member getInstance() : J2MEKeyFactory =
        J2MEKeyFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_J2MEKeyFactory()
    
    abstract init : unit -> unit
    default this.init() : unit =
        let mutable gameKeyArray : GameKey[] = ([| this.gameKeyFactory.DOWN; this.gameKeyFactory.FIRE; this.gameKeyFactory.GAME_A; this.gameKeyFactory.GAME_B; this.gameKeyFactory.GAME_C; this.gameKeyFactory.GAME_D; this.gameKeyFactory.KEY_NUM0; this.gameKeyFactory.KEY_NUM1; this.gameKeyFactory.KEY_NUM2; this.gameKeyFactory.KEY_NUM3; this.gameKeyFactory.KEY_NUM4; this.gameKeyFactory.KEY_NUM5; this.gameKeyFactory.KEY_NUM6; this.gameKeyFactory.KEY_NUM7; this.gameKeyFactory.KEY_NUM8; this.gameKeyFactory.KEY_NUM9; this.gameKeyFactory.KEY_POUND; this.gameKeyFactory.KEY_STAR; this.gameKeyFactory.LEFT; this.gameKeyFactory.LEVEL_DOWN; this.gameKeyFactory.LEVEL_UP; this.gameKeyFactory.NONE; this.gameKeyFactory.RIGHT; this.gameKeyFactory.UP |] : GameKey[])
        let mutable inputFactory : InputFactory = InputFactory.getInstance()
        let mutable index : int = gameKeyArray.Length
        while ((index <- index - 1; index)) >= 0 do
            inputFactory.add(gameKeyArray.[index].getId(), gameKeyArray.[index])
    
    abstract isSubmission : input: Input -> bool
    default this.isSubmission(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, this.gameKeyFactory.FIRE)) then
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
        if (JR.same(input, this.gameKeyFactory.GAME_D)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isBackSpace : input: Input -> bool
    default this.isBackSpace(input: Input) : bool =
        false
    
    abstract isUp : input: Input -> bool
    default this.isUp(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, this.gameKeyFactory.UP)) then
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
        if (JR.same(input, this.gameKeyFactory.DOWN)) then
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
        if (JR.same(input, this.gameKeyFactory.LEFT)) then
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
        if (JR.same(input, this.gameKeyFactory.RIGHT)) then
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
        if (JR.same(input, this.gameKeyFactory.FIRE)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret


