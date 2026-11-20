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
type NullAllBinaryGameCanvas =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ALLBINARY_GAME_CANVAS : NullAllBinaryGameCanvas
    static member NULL_ALLBINARY_GAME_CANVAS with get() : NullAllBinaryGameCanvas = (NullAllBinaryGameCanvas.jclinit(); NullAllBinaryGameCanvas.jcell_NULL_ALLBINARY_GAME_CANVAS) and set (jvalue: NullAllBinaryGameCanvas) = (NullAllBinaryGameCanvas.jclinit(); NullAllBinaryGameCanvas.jcell_NULL_ALLBINARY_GAME_CANVAS <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullAllBinaryGameCanvas.jclinitDone then
            NullAllBinaryGameCanvas.jclinitDone <- true
            NullAllBinaryGameCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        NullAllBinaryGameCanvas.jcell_NULL_ALLBINARY_GAME_CANVAS <- (new NullAllBinaryGameCanvas())
        ()
    new () =
        {  }
    
    abstract getLayerManager : unit -> AllBinaryGameLayerManager
    default this.getLayerManager() : AllBinaryGameLayerManager =
        raise ((new JRuntimeException()))
    
    abstract addCommand : cmd: Command -> unit
    default this.addCommand(cmd: Command) : unit =
        raise ((new JRuntimeException()))
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        raise ((new JRuntimeException()))
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        raise ((new JRuntimeException()))
    
    abstract removeCommand : cmd: Command -> unit
    default this.removeCommand(cmd: Command) : unit =
        raise ((new JRuntimeException()))
    
    abstract setCommandListener : l: CommandListener -> unit
    default this.setCommandListener(l: CommandListener) : unit =
        raise ((new JRuntimeException()))
    interface AllBinaryGameCanvasInterface with
        member this.getLayerManager() : AllBinaryGameLayerManager = this.getLayerManager()
    interface DisplayableInterface with
        member this.addCommand(jp0: Command) : unit = this.addCommand(jp0)
        member this.getHeight() : int = this.getHeight()
        member this.getWidth() : int = this.getWidth()
        member this.removeCommand(jp0: Command) : unit = this.removeCommand(jp0)
        member this.setCommandListener(jp0: CommandListener) : unit = this.setCommandListener(jp0)


