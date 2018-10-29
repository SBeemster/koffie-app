export class MenuItem {
    title: string;
    link: string;
    role?: string;
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
    },
    {
        title: 'Nieuwe Gebruiker',
        link: 'user/create',
        role: 'Admin'
    },
    {
        title: 'Bewerk Gebruiker',
        link: 'user/select',
        role: 'Admin'
    }
]