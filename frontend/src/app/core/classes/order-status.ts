export class OrderStatus {
    orderStatusId: string;
    statusName: string;
    public static statusArray = [];

    constructor(orderStatusId: string, statusName: string) {
        this.orderStatusId = orderStatusId;
        this.statusName = statusName;
        OrderStatus.statusArray.push(this);
    }
}

