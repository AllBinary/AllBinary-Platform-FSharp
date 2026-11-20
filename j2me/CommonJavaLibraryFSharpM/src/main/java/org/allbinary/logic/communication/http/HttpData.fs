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
type HttpData =
    [<DefaultValue(false)>] val mutable EQUALS : string
    [<DefaultValue(false)>] val mutable PARAM_SEP : string
    [<DefaultValue(false)>] val mutable URL_PARAM_SEP : string
    [<DefaultValue(false)>] val mutable URL_LABEL : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : HttpData
    static member instance with get() : HttpData = (HttpData.jclinit(); HttpData.jcell_instance) and set (jvalue: HttpData) = (HttpData.jclinit(); HttpData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HttpData.jclinitDone then
            HttpData.jclinitDone <- true
            HttpData.jclinitBody()
    static member private jclinitBody() : unit =
        HttpData.jcell_instance <- (new HttpData())
        ()
    member this.jfields_HttpData() : unit =
        this.URL_LABEL <- "Url: "
        ()
    
    static member getInstance() : HttpData =
        HttpData.instance
    
    new () as this =
        {  }
        then
            this.jfields_HttpData()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        this.EQUALS <- commonSeps.EQUALS
        this.PARAM_SEP <- commonSeps.AMPERSAND
        this.URL_PARAM_SEP <- commonSeps.QUESTION
        ()


