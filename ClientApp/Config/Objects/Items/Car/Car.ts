import Engine from "./Parts/Engine";
import UpgradeTypes from "./UpgradeTypes";
import Wheels from "./Parts/Wheels";
import CarPassport from "./CarPassport";
import CarCertificate from "./CarCertificate";

export default class Car
{
    public huy: string;

    constructor(huy: string)
    {
        this.huy = huy;
    }
}