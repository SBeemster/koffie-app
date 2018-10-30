export class MenuItem {
  title: string;
  link: string;
  children?: MenuItem[];
}

export const MENU_ITEMS: MenuItem[] = [
  {
    title: "Plaats Order",
    link: "order/coffees"
  },
  {
    title: "Order Overzicht",
    link: "order/overview"
  },
  {
    title: "Groepen",
    link: "user/group"
  }
];
