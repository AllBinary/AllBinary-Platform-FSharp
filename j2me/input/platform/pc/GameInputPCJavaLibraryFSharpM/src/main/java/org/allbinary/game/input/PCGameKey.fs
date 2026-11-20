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
type PCGameKey =
    inherit Input
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PCGameKey.jclinitDone then
            PCGameKey.jclinitDone <- true
            PCGameKey.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (keyCode: int, name: string) as this =
        { inherit Input(keyCode, name) }
        then
            this.jctor1(keyCode, name)
    member this.jctor1(keyCode: int, name: string) : unit =
        ()
        let mutable id_ : int = this.getId()
        if id_ >= 0 then
            InputFactory.getInstance().add(id_, this)
        ()
    
    override this.ToString() : string =
        JR.nn("PCGameKey: ") + JR.nn(base.ToString())
    
    static member getString(keyCode: int) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable input : Input = InputFactory.getInstance().getInstanceById(keyCode)
        if not (JR.same(input, null)) then
            jret <- input.getName()
            jflow <- 1
        else
            jret <- StringUtil.getInstance().EMPTY_STRING
            jflow <- 1
        jret


