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
type Advertisements =
    [<DefaultValue(false)>] val mutable bannerList : BasicArrayList
    [<DefaultValue(false)>] val mutable pageList : BasicArrayList
    [<DefaultValue(false)>] val mutable myRandomFactory : MyRandomFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Advertisements.jclinitDone then
            Advertisements.jclinitDone <- true
            Advertisements.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_Advertisements()
    member this.jfields_Advertisements() : unit =
        this.bannerList <- (new BasicArrayListD())
        this.pageList <- (new BasicArrayListD())
        this.myRandomFactory <- MyRandomFactory.getInstance()
        ()
    
    abstract addPage : advertisementProcessorInterface: AdvertisementProcessorInterface -> unit
    default this.addPage(advertisementProcessorInterface: AdvertisementProcessorInterface) : unit =
        if not (this.pageList.contains(advertisementProcessorInterface)) then
            ignore (this.pageList.add(advertisementProcessorInterface))
    
    abstract startRandomPage : unit -> unit
    default this.startRandomPage() : unit =
        let mutable size : int = this.pageList.size()
        if size > 0 then
            let mutable random : int = this.myRandomFactory.getAbsoluteNextInt(size)
            let mutable advertisementProcessorInterface : AdvertisementProcessorInterface = (box (this.pageList.objectArray.[random]) :?> AdvertisementProcessorInterface)
            advertisementProcessorInterface.start()
    
    abstract processRandomPage : unit -> unit
    default this.processRandomPage() : unit =
        if LockedUtil.getInstance().isLocked() then
            let mutable size : int = this.pageList.size()
            if size > 0 then
                let mutable random : int = this.myRandomFactory.getAbsoluteNextInt(size)
                let mutable advertisementProcessorInterface : AdvertisementProcessorInterface = (box (this.pageList.objectArray.[random]) :?> AdvertisementProcessorInterface)
                advertisementProcessorInterface.process_()
    
    abstract stopAllPage : unit -> unit
    default this.stopAllPage() : unit =
        let mutable index : int = this.pageList.size()
        while ((index <- index - 1; index)) >= 0 do
            let mutable advertisementProcessorInterface : AdvertisementProcessorInterface = (box (this.pageList.objectArray.[index]) :?> AdvertisementProcessorInterface)
            advertisementProcessorInterface.stop()
    
    abstract addBanner : advertisementProcessorInterface: AdvertisementProcessorInterface -> unit
    default this.addBanner(advertisementProcessorInterface: AdvertisementProcessorInterface) : unit =
        if not (this.bannerList.contains(advertisementProcessorInterface)) then
            ignore (this.bannerList.add(advertisementProcessorInterface))
    
    abstract startAll : unit -> unit
    default this.startAll() : unit =
        let mutable index : int = this.bannerList.size()
        while ((index <- index - 1; index)) >= 0 do
            let mutable advertisementProcessorInterface : AdvertisementProcessorInterface = (box (this.bannerList.objectArray.[index]) :?> AdvertisementProcessorInterface)
            advertisementProcessorInterface.start()
    
    abstract stopAllBanner : unit -> unit
    default this.stopAllBanner() : unit =
        let mutable index : int = this.bannerList.size()
        while ((index <- index - 1; index)) >= 0 do
            let mutable advertisementProcessorInterface : AdvertisementProcessorInterface = (box (this.bannerList.objectArray.[index]) :?> AdvertisementProcessorInterface)
            advertisementProcessorInterface.stop()
    
    abstract getBanner : index: int -> AdvertisementProcessorInterface
    default this.getBanner(index: int) : AdvertisementProcessorInterface =
        let mutable advertisementProcessorInterface : AdvertisementProcessorInterface = (box (this.bannerList.objectArray.[index]) :?> AdvertisementProcessorInterface)
        advertisementProcessorInterface
    
    abstract stopAll : unit -> unit
    default this.stopAll() : unit =
        this.stopAllBanner()
        this.stopAllPage()


