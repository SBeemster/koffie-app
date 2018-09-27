export class MenuItem {
    title: String;
    link: String;
    children?: MenuItem[];
}

export const MENU_ITEMS: MenuItem[] = [
    {
        title: 'Order',
        link: 'order',
        children: [
            {
                title: 'Place',
                link: 'order/place'
            },
            {
                title: 'Overview',
                link: 'order/overview'
            }
        ]
    },
    {
        title: 'User',
        link: 'user',
        children: [
            {
                title: 'Group',
                link: 'user/group'
            }
        ]
    }
]