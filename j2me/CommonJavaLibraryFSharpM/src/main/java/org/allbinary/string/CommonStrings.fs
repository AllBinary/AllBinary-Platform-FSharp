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
type CommonStrings =
    [<DefaultValue(false)>] val mutable EMPTY : string
    [<DefaultValue(false)>] val mutable CREATE_IMAGE : string
    [<DefaultValue(false)>] val mutable PLEASE_WAIT : string
    [<DefaultValue(false)>] val mutable PLEASE_WAIT_FOR_SERVER : string
    [<DefaultValue(false)>] val mutable PERIODS : string
    [<DefaultValue(false)>] val mutable LOADING : string
    [<DefaultValue(false)>] val mutable CONSTRUCTOR : string
    [<DefaultValue(false)>] val mutable START : string
    [<DefaultValue(false)>] val mutable END : string
    [<DefaultValue(false)>] val mutable EXCEPTION : string
    [<DefaultValue(false)>] val mutable EXCEPTION_LABEL : string
    [<DefaultValue(false)>] val mutable CLEANUP : string
    [<DefaultValue(false)>] val mutable INIT : string
    [<DefaultValue(false)>] val mutable CLOSE : string
    [<DefaultValue(false)>] val mutable UP : string
    [<DefaultValue(false)>] val mutable DOWN : string
    [<DefaultValue(false)>] val mutable LEFT : string
    [<DefaultValue(false)>] val mutable RIGHT : string
    [<DefaultValue(false)>] val mutable DIRECTION_NAME : string[]
    [<DefaultValue(false)>] val mutable CREATE : string
    [<DefaultValue(false)>] val mutable REMOVE : string
    [<DefaultValue(false)>] val mutable UPDATE : string
    [<DefaultValue(false)>] val mutable DELETE : string
    [<DefaultValue(false)>] val mutable delete : string
    [<DefaultValue(false)>] val mutable LOAD : string
    [<DefaultValue(false)>] val mutable SAVE : string
    [<DefaultValue(false)>] val mutable ADD : string
    [<DefaultValue(false)>] val mutable DROP : string
    [<DefaultValue(false)>] val mutable INSERT : string
    [<DefaultValue(false)>] val mutable VISIT : string
    [<DefaultValue(false)>] val mutable START_METHOD_NAME : string
    [<DefaultValue(false)>] val mutable END_METHOD_NAME : string
    [<DefaultValue(false)>] val mutable GET : string
    [<DefaultValue(false)>] val mutable PROCESS : string
    [<DefaultValue(false)>] val mutable GET_INSTANCE : string
    [<DefaultValue(false)>] val mutable GET_LIST : string
    [<DefaultValue(false)>] val mutable RUN : string
    [<DefaultValue(false)>] val mutable START_RUNNABLE : string
    [<DefaultValue(false)>] val mutable RUNNING : string
    [<DefaultValue(false)>] val mutable END_RUNNABLE : string
    [<DefaultValue(false)>] val mutable DISABLE : string
    [<DefaultValue(false)>] val mutable ENABLE : string
    [<DefaultValue(false)>] val mutable SUCCESS : string
    [<DefaultValue(false)>] val mutable FAILURE : string
    [<DefaultValue(false)>] val mutable NOT_IMPLEMENTED : string
    [<DefaultValue(false)>] val mutable UNKNOWN : string
    [<DefaultValue(false)>] val mutable ON_EVENT : string
    [<DefaultValue(false)>] val mutable IS_VALID : string
    [<DefaultValue(false)>] val mutable TOSTRING : string
    [<DefaultValue(false)>] val mutable ADD_LISTENER : string
    [<DefaultValue(false)>] val mutable REMOVE_LISTENER : string
    [<DefaultValue(false)>] val mutable SIZE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommonStrings
    static member instance with get() : CommonStrings = (CommonStrings.jclinit(); CommonStrings.jcell_instance) and set (jvalue: CommonStrings) = (CommonStrings.jclinit(); CommonStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonStrings.jclinitDone then
            CommonStrings.jclinitDone <- true
            CommonStrings.jclinitBody()
    static member private jclinitBody() : unit =
        CommonStrings.jcell_instance <- (new CommonStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_CommonStrings()
    member this.jfields_CommonStrings() : unit =
        this.EMPTY <- "Empty"
        this.CREATE_IMAGE <- "createImage"
        this.PLEASE_WAIT <- "Please Wait"
        this.PLEASE_WAIT_FOR_SERVER <- "Please Wait Getting Data From Server..."
        this.PERIODS <- "..."
        this.LOADING <- "Loading..."
        this.CONSTRUCTOR <- "Constructor"
        this.START <- "Start"
        this.END <- "End"
        this.EXCEPTION <- "Exception"
        this.EXCEPTION_LABEL <- "Exception: "
        this.CLEANUP <- "cleanup"
        this.INIT <- "init"
        this.CLOSE <- "close"
        this.UP <- "up"
        this.DOWN <- "down"
        this.LEFT <- "left"
        this.RIGHT <- "right"
        this.DIRECTION_NAME <- ([| this.DOWN; this.LEFT; this.RIGHT; this.UP |] : string[])
        this.CREATE <- "Create"
        this.REMOVE <- "Remove"
        this.UPDATE <- "Update"
        this.DELETE <- "Delete"
        this.delete <- "delete"
        this.LOAD <- "load"
        this.SAVE <- "save"
        this.ADD <- "Add"
        this.DROP <- "Drop"
        this.INSERT <- "Insert"
        this.VISIT <- "visit"
        this.START_METHOD_NAME <- this.START
        this.END_METHOD_NAME <- "end"
        this.GET <- "get"
        this.PROCESS <- "process"
        this.GET_INSTANCE <- "getInstance"
        this.GET_LIST <- "getList"
        this.RUN <- "run"
        this.START_RUNNABLE <- "Start Runnable"
        this.RUNNING <- "Running"
        this.END_RUNNABLE <- "End Runnable"
        this.DISABLE <- "disable"
        this.ENABLE <- "enable"
        this.SUCCESS <- "Command Success"
        this.FAILURE <- "Command Failed"
        this.NOT_IMPLEMENTED <- "Not Implemented"
        this.UNKNOWN <- "Unknown"
        this.ON_EVENT <- "onEvent"
        this.IS_VALID <- "isValid"
        this.TOSTRING <- "toString"
        this.ADD_LISTENER <- "addListener"
        this.REMOVE_LISTENER <- "removeListener"
        this.SIZE <- "size"
        ()
    
    static member getInstance() : CommonStrings =
        CommonStrings.instance


