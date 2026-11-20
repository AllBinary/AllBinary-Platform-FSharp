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
type CommandCurrentSelectionFormFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandCurrentSelectionFormFactory.jclinitDone then
            CommandCurrentSelectionFormFactory.jclinitDone <- true
            CommandCurrentSelectionFormFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member getInstance(title: string, items: ABCustomItem[], rectangle: Rectangle, formType: FormType, border: int, moveForSmallScreen: bool, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : ScrollSelectionForm =
        let mutable jflow = 0
        let mutable jret : ScrollSelectionForm = Unchecked.defaultof<ScrollSelectionForm>
        if Features.getInstance().isFeature(TouchFeatureFactory.getInstance().TOUCH_ENABLED) then
            let mutable scrollSelectionForm : ScrollSelectionForm = (new CommandCurrentSelectionForm(title, items, border, moveForSmallScreen, backgroundBasicColor, foregroundBasicColor))
            scrollSelectionForm.init(rectangle, formType)
            jret <- scrollSelectionForm
            jflow <- 1
        else
            jret <- ScrollSelectionFormNoneFactory.getInstance()
            jflow <- 1
        jret


