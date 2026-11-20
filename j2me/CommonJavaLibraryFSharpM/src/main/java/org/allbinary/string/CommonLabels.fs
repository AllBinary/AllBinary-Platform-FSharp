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
type CommonLabels =
    [<DefaultValue(false)>] val mutable WIDTH_LABEL : string
    [<DefaultValue(false)>] val mutable HEIGHT_LABEL : string
    [<DefaultValue(false)>] val mutable END_LABEL : string
    [<DefaultValue(false)>] val mutable TOTAL_LABEL : string
    [<DefaultValue(false)>] val mutable INDEX_LABEL : string
    [<DefaultValue(false)>] val mutable START_LABEL : string
    [<DefaultValue(false)>] val mutable COMMAND_LABEL : string
    [<DefaultValue(false)>] val mutable NAME_LABEL : string
    [<DefaultValue(false)>] val mutable START : string
    [<DefaultValue(false)>] val mutable ELAPSED : string
    [<DefaultValue(false)>] val mutable CURRENT : string
    [<DefaultValue(false)>] val mutable NEXT : string
    [<DefaultValue(false)>] val mutable ITEM_LABEL : string
    [<DefaultValue(false)>] val mutable RESULT_ : string
    [<DefaultValue(false)>] val mutable COLON_SEP : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommonLabels
    static member instance with get() : CommonLabels = (CommonLabels.jclinit(); CommonLabels.jcell_instance) and set (jvalue: CommonLabels) = (CommonLabels.jclinit(); CommonLabels.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonLabels.jclinitDone then
            CommonLabels.jclinitDone <- true
            CommonLabels.jclinitBody()
    static member private jclinitBody() : unit =
        CommonLabels.jcell_instance <- (new CommonLabels())
        ()
    new () as this =
        {  }
        then
            this.jfields_CommonLabels()
    member this.jfields_CommonLabels() : unit =
        this.WIDTH_LABEL <- " Width: "
        this.HEIGHT_LABEL <- " Height: "
        this.END_LABEL <- "End: "
        this.TOTAL_LABEL <- "Total: "
        this.INDEX_LABEL <- "index: "
        this.START_LABEL <- "Start: "
        this.COMMAND_LABEL <- "Command: "
        this.NAME_LABEL <- "Name: "
        this.START <- this.START_LABEL
        this.ELAPSED <- " Elapsed: "
        this.CURRENT <- " Current: "
        this.NEXT <- "Next"
        this.ITEM_LABEL <- "Item: "
        this.RESULT_ <- "Result: "
        this.COLON_SEP <- ": "
        ()
    
    static member getInstance() : CommonLabels =
        CommonLabels.instance


