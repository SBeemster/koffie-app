export class MenuItem {
    title: String;
    link: String;
    children?: MenuItem[];
}

export const MENU_ITEMS: MenuItem[] = [
    {
        title: 'Plaats Order',
        link: 'order/place'
    },
    {
        title: 'Order Overzicht',
        link: 'order/overview'
    },
    {
        title: 'Groepen',
        link: 'user/group'
    }
]