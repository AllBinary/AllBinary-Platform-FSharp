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
type AllAnalogControllerVisitor =
    inherit AnalogControllerVisitor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllAnalogControllerVisitor.jclinitDone then
            AllAnalogControllerVisitor.jclinitDone <- true
            AllAnalogControllerVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        { inherit AnalogControllerVisitor() }
    
    override this.process_(allbinaryLayerManager: AllBinaryLayerManager, analogLocationInputProcessor: AnalogLocationInputProcessor) : unit =
        let mutable analogLocationInputList : BasicArrayList = AnalogLocationInputFactory.getInstance().getList()
        let mutable analogLocationInput : AnalogLocationInput = null
        let mutable index : int = analogLocationInputList.size() - 1
        while index >= 0 do
            analogLocationInput <- (box (analogLocationInputList.get(index)) :?> AnalogLocationInput)
            analogLocationInputProcessor.process_(allbinaryLayerManager, analogLocationInput)
            index <- index - 1


