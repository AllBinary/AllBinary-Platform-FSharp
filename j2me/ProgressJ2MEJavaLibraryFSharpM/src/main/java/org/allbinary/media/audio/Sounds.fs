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
type Sounds =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable soundStrings : SoundStrings
    [<DefaultValue(false)>] val mutable soundsFactoryInterface : SoundsFactoryInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Sounds.jclinitDone then
            Sounds.jclinitDone <- true
            Sounds.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Sounds() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.soundStrings <- SoundStrings.getInstance()
        ()
    
    new (soundsFactoryInterface: SoundsFactoryInterface) as this =
        {  }
        then
            this.jfields_Sounds()
            this.jctor1(soundsFactoryInterface)
    member this.jctor1(soundsFactoryInterface: SoundsFactoryInterface) : unit =
        this.soundsFactoryInterface <- soundsFactoryInterface
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.INIT)
        let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        this.soundsFactoryInterface.init()
        let mutable soundInterfaceArray : Sound[] = this.soundsFactoryInterface.getSoundInterfaceArray()
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        let mutable indexInteger : Integer = null
        let mutable indexString : string = null
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable i : int = 0
        while i < soundInterfaceArray.Length do
            let mutable soundInterface : Sound = soundInterfaceArray.[i]
            if not (JR.same(soundInterface, null)) then
                indexInteger <- smallIntegerSingletonFactory.getAt(i)
                indexString <- indexInteger.ToString()
                ignore (stringBuffer.delete(0, stringBuffer.length()))
                ignore (stringBuffer.append(commonLabels.INDEX_LABEL))
                ignore (stringBuffer.append(indexString))
                ignore (stringBuffer.append(this.soundStrings.SOUND))
                ignore (stringBuffer.append(JR.getClass(soundInterface)))
                this.logUtil.putF(stringBuffer.ToString(), this, this.commonStrings.INIT)
                soundInterface.init()
                progressCanvas.addNormalPortion(100, (new StringMaker()).append(this.soundStrings.INIT_SOUND).append(indexString).ToString())
            i <- i + 1
        this.soundsFactoryInterface.setInitialized(true)
        this.logUtil.putF(this.commonStrings.END, this, this.commonStrings.INIT)
    
    abstract stopAll : unit -> unit
    default this.stopAll() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.soundStrings.STOP_ALL)
        let mutable soundInterfaceArray : Sound[] = this.soundsFactoryInterface.getSoundInterfaceArray()
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        let mutable player : Player = null
        let mutable index : int = 0
        while index < soundInterfaceArray.Length do
            if not (JR.same(soundInterfaceArray.[index], null)) then
                player <- soundInterfaceArray.[index].getPlayerP()
                if not (JR.same(player, null)) then
                    player.stop()
                    progressCanvas.addPortion(100, this.soundStrings.STOPPING_SOUND, index)
            index <- index + 1
    
    abstract closeAll : unit -> unit
    default this.closeAll() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.soundStrings.CLOSE_ALL)
        let mutable soundInterfaceArray : Sound[] = this.soundsFactoryInterface.getSoundInterfaceArray()
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        let mutable player : Player = null
        let mutable index : int = 0
        while index < soundInterfaceArray.Length do
            if not (JR.same(soundInterfaceArray.[index], null)) then
                player <- soundInterfaceArray.[index].getPlayerP()
                if not (JR.same(player, null)) then
                    player.close()
                    progressCanvas.addPortion(100, this.soundStrings.CLOSING_SOUND, index)
            index <- index + 1


