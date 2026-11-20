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
type PlatformKeyFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (PlatformKeyFactory.jclinit(); PlatformKeyFactory.jcell_instance) and set (jvalue: obj) = (PlatformKeyFactory.jclinit(); PlatformKeyFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformKeyFactory.jclinitDone then
            PlatformKeyFactory.jclinitDone <- true
            PlatformKeyFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformKeyFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () =
        {  }
    
    static member getInstance() : PlatformKeyFactory =
        if (JR.same(PlatformKeyFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            PlatformKeyFactory.instance <- (new PlatformKeyFactory())
        (box (PlatformKeyFactory.instance) :?> PlatformKeyFactory)
    
    abstract getString : keyCode: int -> string
    default this.getString(keyCode: int) : string =
        J2MEGameKey.getString(keyCode)
    
    abstract isSubmission : input: Input -> bool
    default this.isSubmission(input: Input) : bool =
        J2MEKeyFactory.getInstance().isSubmission(input)
    
    abstract isDelete : input: Input -> bool
    default this.isDelete(input: Input) : bool =
        J2MEKeyFactory.getInstance().isDelete(input)
    
    abstract isBackSpace : input: Input -> bool
    default this.isBackSpace(input: Input) : bool =
        J2MEKeyFactory.getInstance().isBackSpace(input)
    
    abstract isLeft : input: Input -> bool
    default this.isLeft(input: Input) : bool =
        J2MEKeyFactory.getInstance().isLeft(input)
    
    abstract isRight : input: Input -> bool
    default this.isRight(input: Input) : bool =
        J2MEKeyFactory.getInstance().isRight(input)
    
    abstract isUp : input: Input -> bool
    default this.isUp(input: Input) : bool =
        J2MEKeyFactory.getInstance().isUp(input)
    
    abstract isDown : input: Input -> bool
    default this.isDown(input: Input) : bool =
        J2MEKeyFactory.getInstance().isDown(input)
    
    abstract isEnter : input: Input -> bool
    default this.isEnter(input: Input) : bool =
        J2MEKeyFactory.getInstance().isEnter(input)


