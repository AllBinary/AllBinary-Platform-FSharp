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
type GameInputProcessorComposite =
    inherit PlayerGameInput
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable gameInputProcessorInterface : GameInputProcessorInterface
    [<DefaultValue(false)>] val mutable NAME_LABEL : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputProcessorComposite.jclinitDone then
            GameInputProcessorComposite.jclinitDone <- true
            GameInputProcessorComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameInputProcessorComposite() : unit =
        this.NAME_LABEL <- " GameInputProcessorInterface: "
        ()
    
    new (name: string, gameInputProcessorInterface: GameInputProcessorInterface) as this =
        { inherit PlayerGameInput((new BasicArrayListD()), (new BasicArrayListD()), -1) }
        then
            this.jfields_GameInputProcessorComposite()
            this.jctor1(name, gameInputProcessorInterface)
    member this.jctor1(name: string, gameInputProcessorInterface: GameInputProcessorInterface) : unit =
        ()
        this.name <- name
        this.gameInputProcessorInterface <- gameInputProcessorInterface
        ()
    
    override this.update() : unit =
        try
            let mutable list_ : BasicArrayList = this.getGameKeyEventList()
            this.gameInputProcessorInterface.onInput(list_)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.UPDATE, e)
            | _ -> reraise ()
    
    override this.ToString() : string =
        (new StringMaker()).append(base.ToString()).append(this.NAME_LABEL).append(this.name).ToString()


