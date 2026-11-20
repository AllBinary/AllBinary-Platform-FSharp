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
type MathData =
    [<DefaultValue(false)>] val mutable EQUALS : string
    [<DefaultValue(false)>] val mutable PLUS : string
    [<DefaultValue(false)>] val mutable GREATER_THAN : string
    [<DefaultValue(false)>] val mutable MINUS : string
    [<DefaultValue(false)>] val mutable DIVIDE : string
    [<DefaultValue(false)>] val mutable MULTIPLY : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : MathData
    static member instance with get() : MathData = (MathData.jclinit(); MathData.jcell_instance) and set (jvalue: MathData) = (MathData.jclinit(); MathData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MathData.jclinitDone then
            MathData.jclinitDone <- true
            MathData.jclinitBody()
    static member private jclinitBody() : unit =
        MathData.jcell_instance <- (new MathData())
        ()
    member this.jfields_MathData() : unit =
        this.PLUS <- "+"
        this.GREATER_THAN <- ">"
        ()
    
    static member getInstance() : MathData =
        MathData.instance
    
    new () as this =
        {  }
        then
            this.jfields_MathData()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        this.EQUALS <- commonSeps.EQUALS
        this.MINUS <- commonSeps.DASH
        this.DIVIDE <- commonSeps.FORWARD_SLASH
        this.MULTIPLY <- CommonPhoneStrings.getInstance().STAR
        ()


