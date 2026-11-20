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
type BaseTouchInput =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable basicArrayListUtil : BasicArrayListUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseTouchInput.jclinitDone then
            BaseTouchInput.jclinitDone <- true
            BaseTouchInput.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BaseTouchInput() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.basicArrayListUtil <- BasicArrayListUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BaseTouchInput()
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.basicArrayListUtil.getImmutableInstance()
    
    override this.ToString() : string =
        JR.getClass(this)


