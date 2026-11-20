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
type BaseChangedGameFeatureListener =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameFeatureUtil : GameFeatureUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable changed : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseChangedGameFeatureListener.jclinitDone then
            BaseChangedGameFeatureListener.jclinitDone <- true
            BaseChangedGameFeatureListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_BaseChangedGameFeatureListener()
    member this.jfields_BaseChangedGameFeatureListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameFeatureUtil <- GameFeatureUtil.getInstance()
        this.list <- (new BasicArrayListD())
        this.changed <- true
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(CommonStrings.getInstance().NOT_IMPLEMENTED, this)
    
    abstract onGameFeatureChange : gameFeatureEvent: GameFeatureEvent -> unit
    default this.onGameFeatureChange(gameFeatureEvent: GameFeatureEvent) : unit =
        this.logUtil.putF((new StringMaker()).append(this.gameFeatureUtil.GAME_FEATURE_CHANGED).append(gameFeatureEvent.getWhatChanged()).ToString(), this, this.gameFeatureUtil.ON_GAME_FEATURE_CHANGE)
        ignore (this.list.add(gameFeatureEvent.getGameOption()))
        this.setChanged(true)
    
    abstract add : gameFeature: Feature -> unit
    default this.add(gameFeature: Feature) : unit =
        ignore (this.list.add(gameFeature))
    
    abstract remove : gameFeature: Feature -> unit
    default this.remove(gameFeature: Feature) : unit =
        ignore (this.list.remove(gameFeature))
    
    abstract setChanged : initialized: bool -> unit
    default this.setChanged(initialized: bool) : unit =
        this.changed <- initialized
        if not (this.isChanged()) then
            this.list.clear()
    
    abstract isChangedFeature : gameFeature: Feature -> bool
    default this.isChangedFeature(gameFeature: Feature) : bool =
        let mutable isChanged : bool = this.list.contains(gameFeature)
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("GameFeature: "))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(gameFeature)))
        ignore (stringBuffer.append(" isFeature: "))
        ignore (stringBuffer.appendboolean(Features.getInstance().isFeature(gameFeature)))
        ignore (stringBuffer.append(" isChanged: "))
        ignore (stringBuffer.appendboolean(isChanged))
        this.logUtil.putF(stringBuffer.ToString(), this, "isChanged")
        isChanged
    
    abstract isChanged : unit -> bool
    default this.isChanged() : bool =
        this.changed
    interface GameFeatureListenerInterface with
        member this.onGameFeatureChange(jp0: GameFeatureEvent) : unit = this.onGameFeatureChange(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


