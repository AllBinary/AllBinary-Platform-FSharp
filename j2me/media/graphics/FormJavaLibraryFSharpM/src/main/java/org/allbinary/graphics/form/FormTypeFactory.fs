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
type FormTypeFactory =
    [<DefaultValue(false)>] val mutable UNK : string
    [<DefaultValue(false)>] val mutable NULL_FORM_TYPE : FormType
    [<DefaultValue(false)>] val mutable TEMP_HORIZONTAL_FORM : FormType
    [<DefaultValue(false)>] val mutable HORIZONTAL_FORM : FormType
    [<DefaultValue(false)>] val mutable VERTICAL_CENTER_FORM : FormType
    [<DefaultValue(false)>] static val mutable private jcell_instance : FormTypeFactory
    static member instance with get() : FormTypeFactory = (FormTypeFactory.jclinit(); FormTypeFactory.jcell_instance) and set (jvalue: FormTypeFactory) = (FormTypeFactory.jclinit(); FormTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FormTypeFactory.jclinitDone then
            FormTypeFactory.jclinitDone <- true
            FormTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FormTypeFactory.jcell_instance <- (new FormTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_FormTypeFactory()
    member this.jfields_FormTypeFactory() : unit =
        this.UNK <- "Unknown FormType"
        this.NULL_FORM_TYPE <- (new FormType(StringUtil.getInstance().NULL_STRING))
        this.TEMP_HORIZONTAL_FORM <- (new FormType("TempHorizontal"))
        this.HORIZONTAL_FORM <- (new FormType("Horizontal"))
        this.VERTICAL_CENTER_FORM <- (new FormType("Vertical"))
        ()
    
    static member getInstance() : FormTypeFactory =
        FormTypeFactory.instance
    
    abstract getFormType : unit -> FormType
    default this.getFormType() : FormType =
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable formType : FormType = null
        if displayInfo.isPortrait() then
            formType <- this.VERTICAL_CENTER_FORM
        else
            formType <- this.HORIZONTAL_FORM
        formType


