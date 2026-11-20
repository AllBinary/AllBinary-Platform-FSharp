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
type GameInputProcessorUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputProcessorUtil.jclinitDone then
            GameInputProcessorUtil.jclinitDone <- true
            GameInputProcessorUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member init(inputProcessorArray: GameInputProcessor[]) : unit =
        let mutable noInputProcessor : GameInputProcessor = GameInputProcessor.getInstance()
        let mutable total : int = InputFactory.getInstance().MAX
        let mutable index : int = 0
        while index < total do
            let mutable inputProcessorCanBeNull : GameInputProcessor = inputProcessorArray.[index]
            if (JR.same(inputProcessorCanBeNull, null)) then
                inputProcessorArray.[index] <- noInputProcessor
            index <- index + 1


