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
type InGameFeatures =
    inherit Init
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InGameFeatures.jclinitDone then
            InGameFeatures.jclinitDone <- true
            InGameFeatures.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        { inherit Init() }
    
    override this.init() : unit =
        let mutable LABEL : string = "Screen Buttons"
        let mutable orientationData : OrientationData = OrientationData.getInstance()
        let mutable exclusiveOrientationSensorVector : BasicArrayList = (box (GameFeatureChoiceGroups.getExclusiveInstance().get().get((box (orientationData.ORIENTATION_SENSOR_INPUT)))) :?> BasicArrayList)
        let mutable inGameFeatureChoiceGroups : InGameFeatureChoiceGroups = InGameFeatureChoiceGroups.getExclusiveInstance()
        if not (JR.same(exclusiveOrientationSensorVector, null)) then
            let mutable inGameExclusiveOrientationSensorVectorCanBeNull : obj = inGameFeatureChoiceGroups.get().get((box (orientationData.ORIENTATION_SENSOR_INPUT)))
            if (JR.same(inGameExclusiveOrientationSensorVectorCanBeNull, null)) then
                this.addToInGameMenu()
            else
                let mutable inGameExclusiveOrientationSensorVector : BasicArrayList = (box (inGameExclusiveOrientationSensorVectorCanBeNull) :?> BasicArrayList)
                if inGameExclusiveOrientationSensorVector.size() = 0 then
                    this.addToInGameMenu()
        let mutable features : Features = Features.getInstance()
        if (features.isFeature(TouchFeatureFactory.getInstance().SHOW_SCREEN_BUTTONS) || features.isFeature(TouchFeatureFactory.getInstance().AUTO_HIDE_SHOW_SCREEN_BUTTONS)) || features.isFeature(TouchFeatureFactory.getInstance().HIDE_SCREEN_BUTTONS) then
            let mutable exclusiveScreenButtonsVector : BasicArrayList = (new BasicArrayListD())
            let mutable touchFeatureFactory : TouchFeatureFactory = TouchFeatureFactory.getInstance()
            ignore (exclusiveScreenButtonsVector.add(touchFeatureFactory.AUTO_HIDE_SHOW_SCREEN_BUTTONS))
            ignore (exclusiveScreenButtonsVector.add(touchFeatureFactory.SHOW_SCREEN_BUTTONS))
            ignore (exclusiveScreenButtonsVector.add(touchFeatureFactory.HIDE_SCREEN_BUTTONS))
            inGameFeatureChoiceGroups.add(LABEL, exclusiveScreenButtonsVector)
    
    member this.addToInGameMenu() : unit =
        let mutable orientationData : OrientationData = OrientationData.getInstance()
        let mutable inGameExclusiveOrientationSensorVector : BasicArrayList = (new BasicArrayListD())
        ignore (inGameExclusiveOrientationSensorVector.add(SensorFeatureFactory.getInstance().ORIENTATION_SENSORS))
        ignore (inGameExclusiveOrientationSensorVector.add(SensorFeatureFactory.getInstance().NO_ORIENTATION))
        InGameFeatureChoiceGroups.getExclusiveInstance().add(orientationData.ORIENTATION_SENSOR_INPUT, inGameExclusiveOrientationSensorVector)
    
    abstract isAny : unit -> bool
    default this.isAny() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable features : Features = Features.getInstance()
        let mutable touchFeatureFactory : TouchFeatureFactory = TouchFeatureFactory.getInstance()
        if (features.isFeature(touchFeatureFactory.SHOW_SCREEN_BUTTONS) || features.isFeature(touchFeatureFactory.AUTO_HIDE_SHOW_SCREEN_BUTTONS)) || features.isFeature(touchFeatureFactory.HIDE_SCREEN_BUTTONS) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            let mutable exclusiveOrientationSensorVector : BasicArrayList = (box (GameFeatureChoiceGroups.getExclusiveInstance().get().get((box (OrientationData.getInstance().ORIENTATION_SENSOR_INPUT)))) :?> BasicArrayList)
            if not (JR.same(exclusiveOrientationSensorVector, null)) then
                jret <- true
                jflow <- 1
            if jflow = 0 then
                jret <- false
                jflow <- 1
        jret


