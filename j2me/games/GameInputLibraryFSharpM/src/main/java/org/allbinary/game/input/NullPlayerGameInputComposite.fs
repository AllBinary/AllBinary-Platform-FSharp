namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullPlayerGameInputComposite =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PLAYER_GAME_INPUT_COMPOSITE : NullPlayerGameInputComposite
    static member NULL_PLAYER_GAME_INPUT_COMPOSITE with get() : NullPlayerGameInputComposite = (NullPlayerGameInputComposite.jclinit(); NullPlayerGameInputComposite.jcell_NULL_PLAYER_GAME_INPUT_COMPOSITE) and set (jvalue: NullPlayerGameInputComposite) = (NullPlayerGameInputComposite.jclinit(); NullPlayerGameInputComposite.jcell_NULL_PLAYER_GAME_INPUT_COMPOSITE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullPlayerGameInputComposite.jclinitDone then
            NullPlayerGameInputComposite.jclinitDone <- true
            NullPlayerGameInputComposite.jclinitBody()
    static member private jclinitBody() : unit =
        NullPlayerGameInputComposite.jcell_NULL_PLAYER_GAME_INPUT_COMPOSITE <- (new NullPlayerGameInputComposite())
        ()
    new () =
        {  }
    
    abstract getName : unit -> string
    default this.getName() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract processInput : layerManager: AllBinaryLayerManager -> unit
    default this.processInput(layerManager: AllBinaryLayerManager) : unit =
        ()
    
    abstract initInputProcessors : unit -> unit
    default this.initInputProcessors() : unit =
        ()
    
    abstract getPlayerGameInput : unit -> PlayerGameInput
    default this.getPlayerGameInput() : PlayerGameInput =
        NoPlayerGameInput.getInstance()
    interface PlayerGameInputCompositeInterface with
        member this.getPlayerGameInput() : PlayerGameInput = this.getPlayerGameInput()
    interface GameInputInterface with
        member this.processInput(jp0: AllBinaryLayerManager) : unit = this.processInput(jp0)
        member this.initInputProcessors() : unit = this.initInputProcessors()
    interface NamedInterface with
        member this.getName() : string = this.getName()


